IF OBJECT_ID('Almis.usp_AuditLogTrailer') IS NOT NULL
BEGIN
    DROP PROCEDURE Almis.usp_AuditLogTrailer
    IF @@ERROR = 0
        PRINT 'Almis.usp_AuditLogTrailer Procedure dropped'
END