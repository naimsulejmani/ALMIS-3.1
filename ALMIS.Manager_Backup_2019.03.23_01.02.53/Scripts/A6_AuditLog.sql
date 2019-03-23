
IF OBJECT_ID('Almis.AuditLog') IS NOT NULL
BEGIN
    DROP TABLE Almis.AuditLog
    IF @@ERROR = 0
        PRINT 'Almis.AuditLog table dropped'
END

CREATE TABLE Almis.AuditLog
(
	AuditLogID          INT NOT NULL,
	TableID             INT NOT NULL,
	RowsAffected        INT NOT NULL,
	[Event]             CHAR(1) NOT NULL,
	PostedDateTime      DATETIME NOT NULL,
	UserName            SYSNAME NOT NULL,
	HostName            SYSNAME NOT NULL,
	ApplicationName     SYSNAME NOT NULL,
	CONSTRAINT pk_AuditLog_AuditLogID PRIMARY KEY NONCLUSTERED(AuditLogID ASC)
)