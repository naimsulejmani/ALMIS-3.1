IF OBJECT_ID('Almis.usp_AuditAutoKey') IS NOT NULL
BEGIN
    DROP PROCEDURE Almis.usp_AuditAutoKey
    IF @@ERROR = 0
        PRINT 'Almis.usp_AuditAutoKey Procedrure dropped'
END