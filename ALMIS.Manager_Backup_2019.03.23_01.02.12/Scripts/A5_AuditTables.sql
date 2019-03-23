IF OBJECT_ID('Almis.AuditTables') IS NOT NULL
BEGIN
    DROP TABLE Almis.AuditTables
    IF @@ERROR = 0
        PRINT 'Almis.AuditTables table dropped'
END
CREATE TABLE Almis.AuditTables
(
	TableID          INT NOT NULL IDENTITY(1, 1),
	TableSchema varchar(128) not null,
	TableName        SYSNAME NOT NULL,
	AuditTable       BIT NOT NULL,
	AuditInserts     BIT NOT NULL,
	AuditUpdates     BIT NOT NULL,
	AuditDeletes     BIT NOT NULL,
	CONSTRAINT pk_AuditTables_TableID PRIMARY KEY NONCLUSTERED(TableID ASC)
)
CREATE UNIQUE NONCLUSTERED INDEX IX_AuditTables_Name ON AuditTables(TableName ASC)
