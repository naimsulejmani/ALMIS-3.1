IF OBJECT_ID('Almis.usp_AuditCreateTriggerForInsertOnTable') IS NOT NULL
BEGIN
    DROP PROCEDURE Almis.usp_AuditCreateTriggerForInsertOnTable
    IF @@ERROR = 0
        PRINT 'Almis.usp_AuditCreateTriggerForInsertOnTable Procedure dropped'
END