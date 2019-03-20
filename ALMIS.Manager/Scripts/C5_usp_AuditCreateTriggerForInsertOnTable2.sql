CREATE PROCEDURE [Almis].[usp_AuditCreateTriggerForInsertOnTable]
	@tableSchema varchar(128),
	@tableName VARCHAR(128)
AS
BEGIN
	DECLARE @sql VARCHAR(MAX)
	SET @sql = 'CREATE TRIGGER [Almis_Tr_Audit_' + @tableName + '_Ins]
	ON ['+@tableSchema+'].[' + @tableName +
	    ']
	FOR INSERT
	AS
	BEGIN
	SET NOCOUNT ON
	DECLARE
		@ValidRun INT,
		@RowsAffected INT,
		@PreExistingID INT,
		@MaxID INT,
		@AuditedUser SYSNAME,
		@AuditID int

	SELECT * INTO #ins FROM   INSERTED
	SELECT @RowsAffected = Count(*) FROM INSERTED

	IF(@RowsAffected>0)
	BEGIN
		SELECT @AuditedUser = NULL

		EXEC @ValidRun = Almis.usp_AuditLogHeader ''0622136C-6B0E-4B90-9BC7-1B71216CD32B'', @AuditID OUTPUT

		IF(@ValidRun<>0) RETURN
		DECLARE @pkSelect varchar(MAX)

		SELECT @pkSelect = COALESCE(@pkSelect+'''','''')+''''''''+COLUMN_NAME +
		''=''''+CONVERT(VARCHAR(892),''+COLUMN_NAME+'')+''''#''''''
		FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS t INNER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE k
		ON t.TABLE_NAME = k.TABLE_NAME AND t.CONSTRAINT_NAME=k.CONSTRAINT_NAME
		WHERE t.TABLE_NAME = ''' + @tableName + ''' AND t.TABLE_SCHEMA='''+@tableSchema+''' AND t.CONSTRAINT_TYPE=''PRIMARY KEY''

		SET @pkSelect = LEFT(@pkSelect,LEN(@pkSelect)-2)+RIGHT(@pkSelect,1)
		if(CHARINDEX(''#'',@pkSelect)>0)
		begin
		SET @pkSelect = REPLACE(@pkSelect,''''''#'''''''''',''''''#'')
		end

		DECLARE @fieldID INT, @fieldName varchar(128),@sql varchar(MAX),@TableID INT
		SELECT @TableID=TableID from Almis.AuditTables where TableName = ''' + @tableName
	    +
	    ''' and TableSchema ='''+@tableSchema+'''
		SET @sql =''''
		DECLARE kolona CURSOR LOCAL FAST_FORWARD
		FOR
		SELECT ac.ColumnID,''[''+ac.ColumnName+'']'' FROM Almis.AuditColumns ac WHERE ac.TableID IN (SELECT at.TableID
                                                     FROM Almis.AuditTables at WHERE at.TableName='''
	    + @tableName +
	    ''' and at.TableSchema ='''+@tableSchema+''') AND ac.AuditColumn=1
		OPEN kolona
		FETCH NEXT FROM kolona INTO @fieldID,@fieldName
		WHILE(@@FETCH_STATUS=0)
		BEGIN
			SET @sql =
			''INSERT INTO Almis.AuditLogDetail (AuditLogID,RowKey,ColumnID,[STATUS],NewValue)''
			SET @sql = @sql + '' SELECT ''+CAST(@AuditID AS VARCHAR(100))+'',''+@pkSelect+'',''+CAST(@fieldID AS VARCHAR(100))+'',0,''+CONVERT(varchar(MAX),@fieldName) + ''
			FROM #ins
			''
			EXEC(@sql)
		FETCH NEXT FROM kolona INTO @fieldID,@fieldName
		END
		CLOSE kolona
		DEALLOCATE kolona
		EXEC Almis.usp_AuditLogTrailer @AuditID,@TableID,@RowsAffected,''I'',@AuditedUser
	END
	END'

	EXEC (@sql)
END