IF OBJECT_ID('Almis.AuditUsers') IS NOT NULL
BEGIN
    DROP TABLE Almis.AuditUsers
    IF @@ERROR = 0
        PRINT 'Almis.AuditUsers table dropped'
END
CREATE TABLE Almis.AuditUsers
(
	Username      VARCHAR(50) NOT NULL,
	Name VARCHAR(100) NOT NULL,
	Surname VARCHAR(100) NOT NULL,
	[Password] VARBINARY(20) NOT NULL,
	canAccess     BIT NOT NULL,
	CONSTRAINT pk_AuditUsers_Username PRIMARY KEY CLUSTERED(Username ASC)
)