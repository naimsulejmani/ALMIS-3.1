IF OBJECT_ID('Almis.usp_InstallAlmisConfig') IS NOT NULL
BEGIN
    DROP PROCEDURE Almis.usp_InstallAlmisConfig
    IF @@ERROR = 0
        PRINT 'Almis.usp_InstallAlmisConfig Procedure dropped'
END