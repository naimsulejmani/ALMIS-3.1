CREATE PROCEDURE [Almis].[usp_GetAuditLogBy]
	@tableName VARCHAR(128),
	@columnName VARCHAR(128),
	@userName VARCHAR(200),
	@hostName VARCHAR(200),
	@applicationName VARCHAR(200),
	@rowKey VARCHAR(512),
	@event VARCHAR(5),
	@before DATETIME,
	@after DATETIME,
	@maximum VARCHAR(5)
AS
BEGIN
	DECLARE @sql VARCHAR(MAX)
	DECLARE @tableNameSql VARCHAR(300)--u kry
	DECLARE @columnNameSql VARCHAR(300)--u kry
	DECLARE @dateSql VARCHAR(400)--u kry
	DECLARE @userNameSql VARCHAR(400)--u kry
	DECLARE @hostNameSql VARCHAR(400)--u kry
	DECLARE @applicationNameSql VARCHAR(400)--u kry
	DECLARE @rowKeySql VARCHAR(800)--u kry
	DECLARE @eventSql VARCHAR(100)--u kry
	DECLARE @beforeSql VARCHAR(30)
	DECLARE @afterSql VARCHAR(30)
	SET @beforeSql = CONVERT(VARCHAR(30), @before, 121) 
	SET @afterSql = CONVERT(VARCHAR(30), @after, 121)
	SET @sql = 'SELECT TOP ' + @maximum + ' * FROM Almis.vw_AuditLog v '
	SET @dateSql = ' WHERE v.PostedDateTime BETWEEN ''' + CAST(@afterSql AS VARCHAR(30))
	    + ''' AND ''' + CAST(@beforeSql AS VARCHAR(30)) + ''' AND '
	
	SELECT @tableNameSql = '',
	       @columnNameSql          = '',
	       @userNameSql            = '',
	       @hostNameSql            = '',
	       @applicationNameSql     = '',
	       @rowKeySql              = '',
	       @eventSql               = ''
	
	IF (@tableName IS NOT NULL)
	BEGIN
	    SET @tableNameSql = ' v.TableName like''%' + @tableName + '%'' AND '
	END
	
	IF (@columnName IS NOT NULL)
	BEGIN
	    SET @columnNameSql = ' v.ColumnName like''%' + @columnName + '%'' AND '
	END
	
	IF (@userName IS NOT NULL)
	BEGIN
	    SET @userNameSql = ' v.UserName like ''%' + @userName + '%'' AND '
	END
	
	IF (@hostName IS NOT NULL)
	BEGIN
	    SET @hostNameSql = ' v.HostName like ''%' + @hostName + '%'' AND '
	END
	
	IF (@applicationName IS NOT NULL)
	BEGIN
	    SET @applicationNameSql = ' v.ApplicationName like ''%' + @applicationName 
	        +
	        '%'' AND '
	END
	
	IF (@rowKey IS NOT NULL)
	BEGIN
	    SET @rowKeySql = ' v.RowKey like ''%' + @rowKey + '%'' AND '
	END
	
	IF (@event IS NOT NULL)
	BEGIN
	    SET @eventSql = '''' + @event + ''' like ''%''+v.[Event]+''%'' AND '
	END
	DECLARE @orderBy VARCHAR(200)
	SET @orderBy = ' ORDER BY v.AuditLogID DESC'
	SET @sql = @sql + @dateSql + @tableNameSql + @columnNameSql + @userNameSql +
	    @hostNameSql + @applicationNameSql + @rowKeySql + @eventSql ;
	SET @sql = SUBSTRING(@sql, 0, LEN(@sql) -3) +@orderBy;
	PRINT @sql
	EXEC (@sql)
END