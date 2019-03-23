IF OBJECT_ID('Almis.vw_AuditLog') IS NOT NULL
BEGIN
    DROP VIEW Almis.vw_AuditLog
    IF @@ERROR = 0
        PRINT 'Almis.vw_AuditLog View dropped'
END