IF OBJECT_ID('Almis.usp_RebuildTriggersForDelete') IS NOT NULL
BEGIN
    DROP PROCEDURE Almis.usp_RebuildTriggersForDelete
    IF @@ERROR = 0
        PRINT 'Almis.usp_RebuildTriggersForDelete Procedure dropped'
END