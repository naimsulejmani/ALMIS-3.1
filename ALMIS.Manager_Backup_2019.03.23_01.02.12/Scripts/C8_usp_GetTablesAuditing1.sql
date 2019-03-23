IF OBJECT_ID('Almis.usp_GetTablesAuditing') IS NOT NULL
BEGIN
    DROP PROCEDURE Almis.usp_GetTablesAuditing
    IF @@ERROR = 0
        PRINT 'Almis.usp_GetTablesAuditing Procedure dropped'
END
