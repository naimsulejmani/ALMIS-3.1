CREATE PROCEDURE [Almis].[usp_AuditLogHeader](@ConfigID UNIQUEIDENTIFIER, @AuditLogID INT OUTPUT)
AS
BEGIN
	SET NOCOUNT ON
	IF @ConfigID <> '0622136C-6B0E-4B90-9BC7-1B71216CD32B'
	BEGIN
	    RAISERROR (
	        'AlmisAudit: Konfigurimi i auditimit eshte ndryshuar. Audit trigerat duhet te rigjenerohen qe te perputhen me konfigurim te ri.',
	        18,
	        1
	    ) WITH NOWAIT
	    RETURN 1
	END

	IF CONVERT(VARCHAR, GETDATE(), 112) > '20220101'
	    RETURN 2 -- koha free pa pagese

	EXEC Almis.usp_AuditAutoKey 'Almis.AuditLog',
	     @AuditLogID OUTPUT
END