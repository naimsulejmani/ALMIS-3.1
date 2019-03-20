IF OBJECT_ID('Almis.usp_AuditLogPurge') IS NOT NULL
BEGIN
    DROP PROCEDURE Almis.usp_AuditLogPurge
    IF @@ERROR = 0
        PRINT 'Almis.usp_AuditLogPurge Procedure dropped'
END
