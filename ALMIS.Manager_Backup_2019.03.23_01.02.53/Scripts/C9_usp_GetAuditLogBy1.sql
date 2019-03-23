IF OBJECT_ID('Almis.usp_GetAuditLogBy') IS NOT NULL
BEGIN
    DROP PROCEDURE Almis.usp_GetAuditLogBy
    IF @@ERROR = 0
        PRINT 'Almis.usp_GetAuditLogBy Procedure dropped'
END
