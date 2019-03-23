CREATE PROCEDURE [Almis].[usp_AuditLogPurge]

(@CutoffDateTime DATETIME, @BatchSize INT = NULL)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @NumRows INT
	DECLARE @SQL VARCHAR(1000)
	
	IF @BatchSize IS NULL
	    SELECT @BatchSize = 1000
	
	SELECT @NumRows = COUNT(*)
	FROM   Almis.AuditLog
	WHERE  PostedDateTime < @CutoffDateTime
	
	IF @NumRows <= @BatchSize
	    DELETE 
	    FROM   Almis.AuditLog
	    WHERE  PostedDateTime < @CutoffDateTime
	ELSE
	BEGIN
	    -- Pastro te dhenat e Auditimin per efikasitet
	    
	    -- Gjenero nje SQL String per ti fshire nje grumbull te caktuar te shenimeve
	    SELECT @SQL = 'DELETE FROM Almis.AuditLog WHERE AuditLogID IN ' + CHAR(13) 
	           +
	           '  (SELECT TOP ' + CONVERT(VARCHAR, @BatchSize) + ' AuditLogID' +
	           CHAR(13) +
	           '    FROM Almis.AuditLog WHERE PostedDateTime < ' + CHAR(39) +
	           CONVERT(VARCHAR, @CutoffDateTime, 121) + CHAR(39) + ')'
	           
	           TopOfBatchLoop:
	    
	    -- Fshij rreshtat per ate grumbull, Ekzekuto SQL Stringun
	    EXEC (@SQL)
	         
	         CHECKPOINT
	    
	    -- A kemi akoma per te fshire
	    SELECT @NumRows = COUNT(*)
	    FROM   Almis.AuditLog
	    WHERE  PostedDateTime < @CutoffDateTime
	    
	    -- Kemi me shum per te fshire
	    IF @NumRows > @BatchSize
	        GOTO TopOfBatchLoop
	    
	    -- Kemi me pak se sa duhet fshire
	    IF @NumRows > 0
	        DELETE 
	        FROM   Almis.AuditLog
	        WHERE  PostedDateTime < @CutoffDateTime
	               
	               CHECKPOINT
	END
END