CREATE PROCEDURE Almis.usp_DeleteAuditLog
	@deleteDate DATETIME
AS
BEGIN
	BEGIN TRAN deleting
	DELETE 
	FROM   Almis.AuditLogDetailArchive
	WHERE  AuditLogID  IN (SELECT al.AuditLogID
	                       FROM   Almis.AuditLogArchive al
	                       WHERE  al.PostedDateTime < @deleteDate)
	
	DELETE 
	FROM   Almis.AuditLogArchive
	WHERE  PostedDateTime < @deleteDate
	
	IF(@@ERROR<>0)
	BEGIN
		ROLLBACK TRAN deleting
	END
	ELSE 
	BEGIN 
	COMMIT TRAN deleting
	END
END