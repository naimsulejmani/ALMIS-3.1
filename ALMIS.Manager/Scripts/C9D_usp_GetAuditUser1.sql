IF OBJECT_ID('Almis.usp_GetAuditUser') IS NOT NULL
BEGIN
    DROP PROCEDURE Almis.usp_GetAuditUser
    IF @@ERROR = 0
        PRINT 'Almis.usp_GetAuditUser Procedure dropped'
END