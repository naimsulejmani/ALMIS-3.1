IF OBJECT_ID('Almis.usp_GetAuditTriggerForTable') IS NOT NULL
BEGIN
    DROP PROCEDURE Almis.usp_GetAuditTriggerForTable
    IF @@ERROR = 0
        PRINT 'Almis.usp_GetAuditTriggerForTable Procedure dropped'
END