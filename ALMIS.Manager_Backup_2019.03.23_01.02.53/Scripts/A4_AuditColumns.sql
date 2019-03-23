IF OBJECT_ID('Almis.AuditColumns') IS NOT NULL
BEGIN
    DROP TABLE Almis.AuditColumns
    IF @@ERROR = 0
        PRINT 'Almis.AuditColumns table dropped'
END
CREATE TABLE Almis.AuditColumns
(
	TableID         INT NOT NULL,
	ColumnID        INT NOT NULL IDENTITY(1, 1),
	ColumnName      SYSNAME NOT NULL,
	AuditColumn     BIT NOT NULL,
	KeyColumn       TINYINT NOT NULL,
	CONSTRAINT pk_AuditColumns_TableID_ColumnID PRIMARY KEY NONCLUSTERED(TableID ASC, ColumnID ASC),
)