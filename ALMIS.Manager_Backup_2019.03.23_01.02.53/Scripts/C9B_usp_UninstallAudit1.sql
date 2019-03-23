IF OBJECT_ID('Almis.usp_UninstallAudit') IS NOT NULL
BEGIN
    DROP PROCEDURE Almis.usp_UninstallAudit
    IF @@ERROR = 0
        PRINT 'Almis.usp_UninstallAudit Procedure dropped'
END
