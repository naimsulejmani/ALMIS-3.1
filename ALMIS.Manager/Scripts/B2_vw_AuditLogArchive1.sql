IF OBJECT_ID('Almis.vw_AuditLogArchive') IS NOT NULL
BEGIN
    DROP VIEW Almis.vw_AuditLogArchive
    IF @@ERROR = 0
        PRINT 'Almis.vw_AuditLogArchive View dropped'
END
