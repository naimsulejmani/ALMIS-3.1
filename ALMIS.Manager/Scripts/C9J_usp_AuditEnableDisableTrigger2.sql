CREATE PROCEDURE [Almis].[usp_AuditEnableDisableTrigger]
@tableSchema varchar(128),
	@table VARCHAR(128),
	@triggerName VARCHAR(160),
	@type VARCHAR(7)
AS
BEGIN
	IF (@type IN ('ENABLE', 'DISABLE'))
	BEGIN
	    DECLARE @sql NVARCHAR(MAX)
	    SET @sql = @type + ' TRIGGER '+@tableSchema+'.' + @triggerName + ' ON '+@tableSchema+'.' + @table
	    EXEC sys.sp_executesql @sql
	END
END