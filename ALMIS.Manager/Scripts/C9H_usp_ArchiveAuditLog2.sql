CREATE PROCEDURE Almis.usp_ArchiveAuditLog
	@archiveDate DATETIME
AS
BEGIN
	BEGIN TRAN archiving
	
	INSERT INTO Almis.AuditLogArchive
	SELECT *
	FROM   Almis.AuditLog al
	WHERE  al.PostedDateTime < @archiveDate
	
	INSERT INTO Almis.AuditLogDetailArchive
	SELECT *
	FROM   Almis.AuditLogDetail ald
	WHERE  ald.AuditLogID IN (SELECT al.AuditLogID
	                          FROM   Almis.AuditLog al
	                          WHERE  al.PostedDateTime < @archiveDate)
	
	EXEC Almis.usp_DeleteAuditLog @archiveDate
	
	
	
	IF (@@ERROR <> 0)
	BEGIN
	    ROLLBACK TRAN archiving
	END
	ELSE
	BEGIN
		COMMIT TRAN archiving
	END
END