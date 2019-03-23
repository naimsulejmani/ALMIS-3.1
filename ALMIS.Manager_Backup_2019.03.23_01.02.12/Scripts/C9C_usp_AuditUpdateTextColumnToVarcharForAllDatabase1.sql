IF OBJECT_ID('Almis.usp_AuditUpdateTextColumnToVarcharForAllDatabase') IS NOT NULL
BEGIN
    DROP PROCEDURE Almis.usp_AuditUpdateTextColumnToVarcharForAllDatabase
    IF @@ERROR = 0
        PRINT 'Almis.usp_AuditUpdateTextColumnToVarcharForAllDatabase Procedure dropped'
END