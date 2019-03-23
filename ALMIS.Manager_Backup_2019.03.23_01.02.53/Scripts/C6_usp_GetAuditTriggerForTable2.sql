CREATE PROCEDURE [Almis].[usp_GetAuditTriggerForTable]
	@tableSchema varchar(128),
	@tableName VARCHAR(128)
AS
BEGIN
    SELECT  s.name AS TableSchema,
            T.name AS TableName,
            TR.name AS TriggerName,
            TR.is_disabled AS [IsDisabled] --or objectproperty(object_id('TriggerName'), 'ExecIsTriggerDisabled')
    FROM    [sys].[triggers] AS TR
            INNER JOIN sys.tables AS T ON TR.parent_id = T.object_id
            INNER JOIN sys.schemas AS s ON s.schema_id = T.schema_id
    WHERE  T.name=@tableName and TR.name LIKE 'Almis_Tr_Audit_%' AND 
			s.name = @tableSchema
END