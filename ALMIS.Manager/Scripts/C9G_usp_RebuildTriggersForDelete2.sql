CREATE PROCEDURE Almis.usp_RebuildTriggersForDelete
	@tableSchema varchar(128),
	@tableName VARCHAR(128),
	@type BIT
AS
BEGIN
	DECLARE @exist BIGINT
	SELECT @exist = OBJECT_ID(@tableSchema+'.Almis_TR_Audit_' + @tableName + '_Del')
	
	IF (@type = 1 AND @exist IS NULL)
	BEGIN
	    EXEC Almis.usp_AuditCreateTriggerForDeleteOnTable @tableSchema,@tableName
	    UPDATE Almis.AuditTables
	    SET    AuditDeletes     = 1
	    WHERE  TableName        = @tableName
	END
	
	IF (@type = 0 AND @exist IS NOT NULL)
	BEGIN
	    DECLARE @sql VARCHAR(MAX)
	    SET @sql = 'DROP TRIGGER '+@tableSchema+'.Almis_TR_Audit_' + @tableName + '_Del'
	    UPDATE Almis.AuditTables
	    SET    AuditDeletes = 0
	    WHERE  TableName = @tableName
	    
	    EXEC (@sql)
	END
END