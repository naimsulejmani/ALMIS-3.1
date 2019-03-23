IF OBJECT_ID('Almis.usp_GetColumnForTable') IS NOT NULL
BEGIN
    DROP PROCEDURE Almis.usp_GetColumnForTable
    IF @@ERROR = 0
        PRINT 'Almis.usp_GetColumnForTable Procedure dropped'
END