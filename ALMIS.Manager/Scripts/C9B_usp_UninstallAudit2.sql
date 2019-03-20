CREATE PROCEDURE Almis.usp_UninstallAudit
AS
BEGIN
	DECLARE @objectName     VARCHAR(256),
	        @objectType     VARCHAR(256),
			@objectSchema varchar(128)
	
	DECLARE crc CURSOR  
	FOR
	   SELECT  s.name,o.name
	   FROM    sys.objects AS o INNER JOIN sys.schemas AS s ON o.schema_id = s.schema_id
	   WHERE   o.object_id IN (SELECT  t.object_id
                        FROM    sys.triggers t
                        WHERE   t.name LIKE 'Almis_Tr_Audit_%_Ins'
                                OR t.name LIKE 'Almis_Tr_Audit_%_Upd'
                                OR t.name LIKE 'Almis_Tr_Audit_%_Del')
	
	OPEN crc
	FETCH NEXT FROM crc INTO @objectSchema,@objectName
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
	    EXEC ('DROP TRIGGER '+@objectSchema+'.' + @objectName)
	    FETCH NEXT FROM crc INTO @objectSchema,@objectName
	END
	CLOSE crc
	DEALLOCATE crc
	
	DECLARE crs CURSOR  
	FOR
	    SELECT o.name,
	           o.[type]
	    FROM   sys.objects o
	           INNER JOIN sys.schemas s
	                ON  s.[schema_id] = o.[schema_id]
	    WHERE  s.name = 'Almis'
	           AND o.[type] NOT IN ('PK', 'DF', 'SQ', 'IT', 'TR', 'UQ', 'F', 'IF', 'D')
	    ORDER BY
	           o.[object_id] ASC
	
	OPEN crs
	FETCH NEXT FROM crs INTO @objectName,@objectType
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
	    IF (@objectType = 'U')
	    BEGIN
	        EXEC ('DROP TABLE Almis.' + @objectName)
	    END
	    ELSE 
	    IF (@objectType = 'P')
	    BEGIN
	        EXEC ('DROP PROCEDURE Almis.' + @objectName)
	    END
	    ELSE 
	    IF (@objectType = 'V')
	    BEGIN
	        EXEC ('DROP VIEW Almis.' + @objectName)
	    END
	    ELSE 
	    IF (@objectType = 'FN')
	    BEGIN
	        EXEC ('DROP FUNCTION Almis.' + @objectName)
	    END
	    
	    FETCH NEXT FROM crs INTO @objectName,@objectType
	END
	CLOSE crs
	DEALLOCATE crs
	DROP SCHEMA Almis
END
