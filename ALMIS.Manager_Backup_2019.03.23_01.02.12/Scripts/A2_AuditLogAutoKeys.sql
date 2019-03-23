IF OBJECT_ID('Almis.AuditLogAutoKeys') IS NOT NULL
BEGIN
    DROP TABLE Almis.AuditLogAutoKeys
    IF @@ERROR = 0
        PRINT 'Almis.AuditLogAutoKeys table dropped'
END
CREATE TABLE Almis.AuditLogAutoKeys
(
	TableName     VARCHAR(128) NOT NULL,
	KeyValue      INT NOT NULL,
	CONSTRAINT pk_AuditLogAutoKeys PRIMARY KEY CLUSTERED(TableName ASC)
)
ALTER TABLE [Almis].[AuditLogAutoKeys] ADD  CONSTRAINT 
[DF_AuditLogAutoKeys_KeyValue]  DEFAULT((0)) FOR [KeyValue]