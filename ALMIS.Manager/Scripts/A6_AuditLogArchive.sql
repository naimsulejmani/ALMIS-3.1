IF OBJECT_ID('Almis.AuditLogArchive') IS NOT NULL
BEGIN
    DROP TABLE Almis.AuditLogArchive
    IF @@ERROR = 0
        PRINT 'Almis.AuditLogArchive table dropped'
END

CREATE TABLE Almis.AuditLogArchive
(
	AuditLogID          INT NULL,
	TableID             INT NULL,
	RowsAffected        INT NULL,
	[Event]             CHAR(1) NULL,
	PostedDateTime      DATETIME NULL,
	UserName            SYSNAME NULL,
	HostName            SYSNAME NULL,
	ApplicationName     SYSNAME NULL
)