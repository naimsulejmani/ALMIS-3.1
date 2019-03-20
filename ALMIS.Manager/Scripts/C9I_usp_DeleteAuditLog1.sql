IF OBJECT_ID('Almis.usp_DeleteAuditLog') IS NOT NULL
BEGIN
    DROP PROCEDURE Almis.usp_DeleteAuditLog
    IF @@ERROR = 0
        PRINT 'Almis.usp_DeleteAuditLog Procedure dropped'
END

