IF OBJECT_ID('Almis.usp_AuditEnableDisableTrigger') IS NOT NULL
BEGIN
    DROP PROCEDURE Almis.usp_AuditEnableDisableTrigger
    IF @@ERROR = 0
        PRINT 'Almis.usp_AuditEnableDisableTrigger Procedure dropped'
END

