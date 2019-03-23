CREATE PROCEDURE Almis.usp_GetAuditUser
	@username VARCHAR(50)
	,@password varchar(100)
AS
BEGIN
	    SELECT a.*
	    FROM   Almis.AuditUsers a
	    WHERE  a.Username = @username and a.Password=@password;
END