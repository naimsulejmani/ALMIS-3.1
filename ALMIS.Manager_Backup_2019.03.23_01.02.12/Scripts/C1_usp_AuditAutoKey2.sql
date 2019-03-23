CREATE PROCEDURE [Almis].[usp_AuditAutoKey](@TableName VARCHAR(30) = NULL, @KeyValue INT OUTPUT)
AS
BEGIN
	SET NOCOUNT ON
	SELECT @KeyValue = 0
	IF @TableName IS NULL
	BEGIN
	    RAISERROR(
	        'Almis.usp_AuditAutoKey i duhet se paku nje @TableName parameter',
	        16,
	        1
	    )
	    RETURN (1)
	END
	
	BEGIN TRANSACTION
	UPDATE Almis.AuditLogAutoKeys
	SET    KeyValue = KeyValue + 1
	WHERE  TableName = @TableName
	
	IF @@ROWCOUNT = 0
	    INSERT INTO Almis.AuditLogAutoKeys
	      (
	        TableName,
	        KeyValue
	      )
	    VALUES
	      (
	        @TableName,
	        1
	      )
	
	SELECT @KeyValue = KeyValue
	FROM   Almis.AuditLogAutoKeys
	WHERE  TableName = @TableName
	
	COMMIT TRANSACTION
END