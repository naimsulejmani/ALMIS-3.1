CREATE PROCEDURE Almis.usp_InstallAlmisConfig
AS
BEGIN
	INSERT INTO Almis.AuditConfig
	  (
	    NAME,
	    [VALUE]
	  )
	VALUES
	  (
	    'PREREQUIREMENTS',
	    'INSTALLED'
	  )
	INSERT INTO Almis.AuditConfig
	  (
	    NAME,
	    [VALUE]
	  )
	VALUES
	  (
	    'ORGANIZATION',
	    'NONAME'
	  )
	INSERT INTO Almis.AuditConfig
	  (
	    NAME,
	    [VALUE]
	  )
	VALUES
	  (
	    'DATABASE',
	    'NONAME'
	  )
	INSERT INTO Almis.AuditConfig
	  (
	    NAME,
	    [VALUE]
	  )
	VALUES
	  (
	    'AUDIT_LOG_TYPE',
	    'ROW BASED'
	  )
	INSERT INTO Almis.AuditConfig
	  (
	    NAME,
	    [VALUE]
	  )
	VALUES
	  (
	    'CAN_CHANGE_TABLE',
	    'YES'
	  )
	INSERT INTO Almis.AuditConfig
	  (
	    NAME,
	    [VALUE]
	  )
	VALUES
	  (
	    'CAN_CHANGE_COLUMN',
	    'YES'
	  )

	IF EXISTS(
	       SELECT *
	       FROM   Almis.AuditTables at
	   )
	BEGIN
	    DELETE
	    FROM   Almis.AuditTables

	    DBCC CHECKIDENT('Almis.AuditTables', RESEED, 0) WITH NO_INFOMSGS
	END

	INSERT INTO Almis.AuditTables
	  (
	    -- TableID -- this column value is auto-generated
		TableSchema,
	    TableName,
	    AuditTable,
	    AuditInserts,
	    AuditUpdates,
	    AuditDeletes
	  )
	SELECT  t.TABLE_SCHEMA,
			t.TABLE_NAME,
	       0,
	       0,
	       0,
	       0
	FROM   INFORMATION_SCHEMA.TABLES t
	WHERE t.TABLE_TYPE = 'BASE TABLE' and  t.TABLE_NAME NOT IN (	SELECT t.TABLE_NAME
	FROM   INFORMATION_SCHEMA.TABLES t where t.TABLE_SCHEMA='Almis' and t.TABLE_NAME LIKE 'AuditLog%')
	ORDER BY t.TABLE_NAME

	IF EXISTS(
	       SELECT *
	       FROM   Almis.AuditColumns ac
	   )
	BEGIN
	    TRUNCATE TABLE Almis.AuditColumns
	END

	INSERT INTO Almis.AuditColumns
	  (
	    TableID,
	    -- ColumnID -- this column value is auto-generated
	    ColumnName,
	    AuditColumn,
	    KeyColumn
	  )
	SELECT at.TableID,
	       c.COLUMN_NAME,
	       0,
	       0
	FROM   INFORMATION_SCHEMA.[COLUMNS] c
	       INNER JOIN Almis.AuditTables at
	            ON  at.TableName = c.TABLE_NAME
					AND at.TableSchema=c.TABLE_SCHEMA
	ORDER BY
	       at.TableID
END