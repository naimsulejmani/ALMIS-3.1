IF OBJECT_ID('Almis.usp_ArchiveAuditLog') IS NOT NULL
BEGIN
    DROP PROCEDURE Almis.usp_ArchiveAuditLog
    IF @@ERROR = 0
        PRINT 'Almis.usp_ArchiveAuditLog Procedure dropped'
END