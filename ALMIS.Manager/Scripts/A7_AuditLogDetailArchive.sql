IF OBJECT_ID('Almis.AuditLogDetailArchive') IS NOT NULL
BEGIN
    DROP TABLE Almis.AuditLogDetailArchive
    IF @@ERROR = 0
        PRINT 'Almis.AuditLogDetailArchive table dropped'
END
CREATE TABLE Almis.AuditLogDetailArchive
(
	AuditLogID     INT NOT NULL,
	RowKey         VARCHAR(512) NOT NULL,
	ColumnID       INT NOT NULL,
	[Status]       TINYINT NOT NULL,
	OldValue       VARCHAR(MAX) NULL,
	NewValue       VARCHAR(MAX) NULL
)