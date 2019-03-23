CREATE PROCEDURE [Almis].[usp_AuditLogTrailer] (
    @AuditLogID       INT,
    @TableID          INT,
    @RowsAffected     INT,
    @Event            CHAR(1),
    @UserValue        SYSNAME
)
AS
BEGIN
	SET NOCOUNT ON
	IF CONVERT(VARCHAR, GETDATE(), 112) > '20220101'
	    RETURN 2 --afati i perdorimit pa pagese, mund te rigjenerohet


	IF @UserValue IS NULL
	    SELECT @UserValue = SUSER_SNAME()

	INSERT Almis.AuditLog
	  (
	    AuditLogID,
	    TableID,
	    RowsAffected,
	    [Event],
	    UserName
	  )
	VALUES
	  (
	    @AuditLogID,
	    @TableID,
	    @RowsAffected,
	    @Event,
	    @UserValue
	  )
END