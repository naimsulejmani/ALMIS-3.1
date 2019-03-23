IF OBJECT_ID('Almis.AuditConfig') IS NOT NULL
BEGIN
    DROP TABLE Almis.AuditConfig
    IF @@ERROR = 0
        PRINT 'Almis.AuditConfig table dropped'
END
CREATE TABLE Almis.AuditConfig
(
	[Name]     VARCHAR(100) NOT NULL,
	VALUE      VARCHAR(MAX) NOT NULL,
	CONSTRAINT pk_AuditConfig_Name PRIMARY KEY CLUSTERED([Name] ASC)
)
