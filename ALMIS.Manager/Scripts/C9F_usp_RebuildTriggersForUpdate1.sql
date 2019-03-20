IF OBJECT_ID('Almis.usp_RebuildTriggersForUpdate') IS NOT NULL
BEGIN
    DROP PROCEDURE Almis.usp_RebuildTriggersForUpdate
    IF @@ERROR = 0
        PRINT 'Almis.usp_RebuildTriggersForUpdate Procedure dropped'
END