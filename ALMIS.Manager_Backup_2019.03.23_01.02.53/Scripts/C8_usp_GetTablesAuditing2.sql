CREATE PROCEDURE [Almis].[usp_GetTablesAuditing]
AS 
BEGIN
    IF OBJECT_ID('Almis.AuditTables') IS NOT NULL 
        BEGIN
            WITH    cte
                      AS (SELECT    0 AS TableID,
                                    t.TABLE_SCHEMA AS TableSchema,
                                    t.TABLE_NAME AS TableName,
                                    0 AS AuditTable,
                                    0 AS AuditInserts,
                                    0 AS AuditUpdates,
                                    0 AS AuditDeletes
                          FROM      INFORMATION_SCHEMA.TABLES t
                          WHERE     t.TABLE_TYPE = 'BASE TABLE'
                                    AND t.TABLE_NAME NOT IN (
                                    SELECT  at.TableName
                                    FROM    Almis.AuditTables at
                                    UNION
                                    SELECT  t.TABLE_NAME
                                    FROM    INFORMATION_SCHEMA.TABLES t
                                    WHERE   t.TABLE_SCHEMA = 'Almis'
                                            AND t.TABLE_NAME LIKE 'AuditLog%')
                          UNION
                          SELECT    *
                          FROM      Almis.AuditTables at)
                SELECT  *
                FROM    cte
                ORDER BY TableSchema,
                        TableName
        END
    ELSE 
        BEGIN
            SELECT  0 AS TableID,
					t.TABLE_SCHEMA AS TableSchema,
                    t.TABLE_NAME AS TableName,
                    0 AS AuditTable,
                    0 AS AuditInserts,
                    0 AS AuditUpdates,
                    0 AS AuditDeletes
            FROM    INFORMATION_SCHEMA.TABLES t
            WHERE   t.TABLE_TYPE = 'BASE TABLE'
                    AND t.TABLE_NAME NOT IN (
                    SELECT  t.TABLE_NAME
                    FROM    INFORMATION_SCHEMA.TABLES t
                    WHERE   t.TABLE_SCHEMA = 'Almis'
                            AND t.TABLE_NAME LIKE 'AuditLog%')
            ORDER BY t.TABLE_NAME
        END
END