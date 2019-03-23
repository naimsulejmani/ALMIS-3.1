IF OBJECT_ID('Almis.usp_AuditCreateTriggerForUpdateOnTable') IS NOT NULL
BEGIN
    DROP PROCEDURE Almis.usp_AuditCreateTriggerForUpdateOnTable
    IF @@ERROR = 0
        PRINT 'Almis.usp_AuditCreateTriggerForUpdateOnTable Procedure dropped'
END