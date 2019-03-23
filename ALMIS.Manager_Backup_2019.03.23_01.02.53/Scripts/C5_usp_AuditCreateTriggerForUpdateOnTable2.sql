CREATE PROCEDURE [Almis].[usp_AuditCreateTriggerForUpdateOnTable]
	@tableSchema varchar(128),
	@tableName VARCHAR(128)
AS
BEGIN
	DECLARE @sql VARCHAR(MAX)
	SET @sql = 'CREATE TRIGGER [Almis_Tr_Audit_' + @tableName + '_Upd]
	ON ['+@tableSchema+'].[' + @tableName +
	    ']
	FOR UPDATE
	AS
	BEGIN
	SET NOCOUNT ON
	DECLARE
		@ValidRun INT,
		@RowsAffected INT,
		@PreExistingID INT,
		@MaxID INT,
		@AuditedUser SYSNAME,
		@AuditID INT,
		@ChangeCount INT,
		@CaptureCount INT
SELECT * INTO #ins FROM   INSERTED
SELECT * INTO #del FROM   DELETED
SELECT @RowsAffected = Count(*) FROM INSERTED

	IF(@RowsAffected>0)
	BEGIN
		SELECT @AuditedUser = NULL
		EXEC @ValidRun = Almis.usp_AuditLogHeader ''0622136C-6B0E-4B90-9BC7-1B71216CD32B'', @AuditID OUTPUT
		IF(@ValidRun<>0) RETURN
		SELECT @CaptureCount=0
		DECLARE @pkSelect varchar(MAX)
		DECLARE @pkCols NVARCHAR(MAX)
		SELECT @pkCols =COALESCE(@pkCols+'''','' on '')+'' AND (i.''+COLUMN_NAME +
		'' =  d.''+COLUMN_NAME+'')''
		FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS t INNER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE k
		ON t.TABLE_NAME = k.TABLE_NAME AND t.CONSTRAINT_NAME=k.CONSTRAINT_NAME
		WHERE t.TABLE_NAME = ''' + @tableName + ''' AND t.TABLE_SCHEMA='''+@tableSchema+''' AND t.CONSTRAINT_TYPE=''PRIMARY KEY''

		SET @pkCols = REPLACE(@pkCols,''on  AND'',''on'')

		SELECT @pkSelect = COALESCE(@pkSelect+'''','''')+''''''''+COLUMN_NAME +
		''=''''+CONVERT(VARCHAR(892),i.''+COLUMN_NAME+'')+''''#''''''
		FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS t INNER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE k
		ON t.TABLE_NAME = k.TABLE_NAME AND t.CONSTRAINT_NAME=k.CONSTRAINT_NAME
		WHERE t.TABLE_NAME = ''' + @tableName +'''  AND t.TABLE_SCHEMA='''+@tableSchema+''' AND t.CONSTRAINT_TYPE=''PRIMARY KEY''

		SET @pkSelect = LEFT(@pkSelect,LEN(@pkSelect)-2)+RIGHT(@pkSelect,1)
		if(CHARINDEX(''#'',@pkSelect)>0)
		begin
		SET @pkSelect = REPLACE(@pkSelect,''''''#'''''''''',''''''#'')
		end
		Select @CaptureCount=0;
		DECLARE @tbl table(id int)
		INSERT INTO @tbl (id) EXEC(''SELECT Count(*) FROM #ins i FULL OUTER JOIN #del d''+@pkCols )
		SET @ChangeCount =(SELECT TOP (1) id from @tbl)
		DECLARE @fieldID INT, @fieldName varchar(128),@sql varchar(MAX),@TableID INT
		SELECT @TableID=TableID from Almis.AuditTables where TableName = ''' + @tableName
	    +''' and TableSchema ='''+@tableSchema+'''
		SET @sql=''''
		DECLARE crc CURSOR LOCAL FAST_FORWARD FOR
		 SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME=''' + @tableName +
	    ''' AND sys.fn_IsBitSetInBitmask(CAST(COLUMNS_UPDATED() AS VARBINARY(254)),COLUMNPROPERTY(OBJECT_ID(TABLE_SCHEMA + ''.'' + TABLE_NAME),COLUMN_NAME,''ColumnID'')) <> 0
		OPEN crc
		FETCH NEXT FROM crc INTO @fieldName
		WHILE(@@FETCH_STATUS=0)
		begin
			SELECT @fieldID = ac.ColumnID FROM Almis.AuditColumns ac
	        WHERE  ac.TableID IN (SELECT at.TableID FROM   Almis.AuditTables at WHERE  at.TableName = ''' + @tableName +
	    ''' and at.TableSchema ='''+@tableSchema+''') AND ac.ColumnName = @fieldName AND ac.AuditColumn=1
			IF(@fieldID IS NOT NULL)
			BEGIN
				SET @sql = ''
				INSERT INTO Almis.AuditLogDetail(AuditLogID,RowKey,ColumnID,[Status],OldValue,NewValue)
				SELECT ''+CAST(@AuditID AS VARCHAR(100))+'',''+@pkSelect+'',''+CAST(@fieldID AS VARCHAR(100))+'',0,CONVERT(VARCHAR(MAX),d.[''+@fieldName+'']),
				CONVERT(VARCHAR(MAX),i.[''+@fieldName+''])
				FROM #ins i full outer join #del d ''+@pkCols+''
				WHERE (d.[''+@fieldName+'']<>i.[''+@fieldName+'']) or
				(d.[''+@fieldName+''] is null and i.[''+@fieldName+''] is not null) or
				(i.[''+@fieldName+''] is null and d.[''+@fieldName+''] is not null)
				''
				EXEC(@sql)
			END
		FETCH NEXT FROM crc INTO @fieldName
		END
		CLOSE crc
		DEALLOCATE crc
		SELECT @CaptureCount=COUNT(*) FROM Almis.AuditLogDetail WHERE AuditLogID=@AuditID
		IF(@CaptureCount>0)
		EXEC Almis.usp_AuditLogTrailer @AuditID,@TableID,@RowsAffected,''U'',@AuditedUser
END
END'

	EXEC (@sql)
END