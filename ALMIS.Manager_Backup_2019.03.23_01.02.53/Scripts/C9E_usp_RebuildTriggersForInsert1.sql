IF OBJECT_ID('Almis.usp_RebuildTriggersForInsert') IS NOT NULL
BEGIN
    DROP PROCEDURE Almis.usp_RebuildTriggersForInsert
    IF @@ERROR = 0
        PRINT 'Almis.usp_RebuildTriggersForInsert Procedure dropped'
END