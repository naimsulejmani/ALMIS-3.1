IF OBJECT_ID('Almis.usp_AuditLogHeader') IS NOT NULL
BEGIN
    DROP PROCEDURE Almis.usp_AuditLogHeader
    IF @@ERROR = 0
        PRINT 'Almis.usp_AuditLogHeader Procedure dropped'
END