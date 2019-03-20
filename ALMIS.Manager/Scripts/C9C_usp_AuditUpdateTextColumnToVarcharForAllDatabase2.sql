CREATE PROCEDURE Almis.usp_AuditUpdateTextColumnToVarcharForAllDatabase
AS
BEGIN
	DECLARE @sql NVARCHAR(MAX)
	DECLARE @columnName VARCHAR(250)
	DECLARE @tableName VARCHAR(128)
	DECLARE @dataType VARCHAR(128)
	
	DECLARE crs CURSOR  
	FOR
	    SELECT c.COLUMN_NAME,
	           c.TABLE_NAME,
	           c.DATA_TYPE
	    FROM   INFORMATION_SCHEMA.[COLUMNS] c
	           INNER JOIN INFORMATION_SCHEMA.TABLES t
	                ON  t.TABLE_NAME = c.TABLE_NAME
	    WHERE  c.DATA_TYPE IN ('text', 'ntext', 'image')
	
	OPEN crs
	FETCH NEXT FROM crs INTO @columnName,@tableName,@dataType
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
	    IF (@dataType = 'text')
	    BEGIN
	        SET @sql = 'ALTER TABLE ' + @tableName + ' ALTER COLUMN ' + @columnName
	            + ' VARCHAR(MAX) NULL'
	    END
	    ELSE 
	    IF (@dataType = 'ntext')
	    BEGIN
	        SET @sql = 'ALTER TABLE ' + @tableName + ' ALTER COLUMN ' + @columnName
	            + ' NVARCHAR(MAX) NULL'
	    END
	    ELSE 
	    IF (@dataType = 'image')
	    BEGIN
	        SET @sql = 'ALTER TABLE ' + @tableName + ' ALTER COLUMN ' + @columnName
	            + ' VARBINARY(MAX) NULL'
	    END
	    
	    EXEC sys.sp_executesql @sql
	    PRINT @sql
	    FETCH NEXT FROM crs INTO @columnName,@tableName,@dataType
	END
	CLOSE crs
	DEALLOCATE crs
END