CREATE PROCEDURE [Almis].[usp_GetColumnForTable]
	@tableName VARCHAR(128)
AS
BEGIN
	IF OBJECT_ID('Almis.AuditTables') IS NOT NULL
	BEGIN
	    IF OBJECT_ID('Almis.AuditColumns') IS NOT NULL
	    BEGIN
	       SELECT DISTINCT ac.ColumnName,
	               ac.AuditColumn,
	               c.DATA_TYPE
	        FROM   Almis.AuditColumns ac
	               INNER JOIN Almis.AuditTables at
	                    ON  at.TableID = ac.TableID
	               INNER JOIN INFORMATION_SCHEMA.[COLUMNS] c
	                    ON  at.TableName = c.TABLE_NAME AND at.TableSchema=c.TABLE_SCHEMA
	                    AND ac.ColumnName = c.COLUMN_NAME
	        WHERE  at.TableName = @tableName
	    END
	    ELSE
	    BEGIN
	        SELECT DISTINCT c.COLUMN_NAME,
	               0
	        FROM   Almis.AuditTables at
	               INNER JOIN INFORMATION_SCHEMA.[COLUMNS] c
	                    ON  at.TableName = c.TABLE_NAME and  at.TableSchema=c.TABLE_SCHEMA
	        WHERE  c.TABLE_NAME = @tableName
	    END
	END
	ELSE
	BEGIN
	    SELECT c.COLUMN_NAME,
	           0,
	           c.DATA_TYPE
	    FROM   INFORMATION_SCHEMA.TABLES t
	           INNER JOIN INFORMATION_SCHEMA.[COLUMNS] c
	                ON  c.TABLE_NAME = t.TABLE_NAME and c.TABLE_SCHEMA=t.TABLE_SCHEMA
	    WHERE  t.TABLE_NAME = @tableName
	END
END