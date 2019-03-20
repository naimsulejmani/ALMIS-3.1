IF OBJECT_ID('Almis.usp_AuditCreateTriggerForDeleteOnTable') IS NOT NULL
BEGIN
    DROP PROCEDURE Almis.usp_AuditCreateTriggerForDeleteOnTable
    IF @@ERROR = 0
        PRINT 'Almis.usp_AuditCreateTriggerForDeleteOnTable Procedure dropped'
END