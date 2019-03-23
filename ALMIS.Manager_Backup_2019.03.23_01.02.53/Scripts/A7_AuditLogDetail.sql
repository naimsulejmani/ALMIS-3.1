IF OBJECT_ID('Almis.AuditLogDetail') IS NOT NULL
BEGIN
    DROP TABLE Almis.AuditLogDetail
    IF @@ERROR = 0
        PRINT 'Almis.AuditLogDetail table dropped'
END
CREATE TABLE Almis.AuditLogDetail
(
	AuditLogID     INT NOT NULL,
	RowKey         VARCHAR(512) NOT NULL,
	ColumnID       INT NOT NULL,
	[Status]       TINYINT NOT NULL,
	OldValue       VARCHAR(MAX) NULL,
	NewValue       VARCHAR(MAX) NULL,
	CONSTRAINT pk_AuditLogDetail_AuditLogID_RowKey_ColumnID PRIMARY KEY 
	NONCLUSTERED(AuditLogID ASC, RowKey ASC, ColumnID ASC)
)