CREATE VIEW [Almis].[vw_AuditLogArchive]
AS
SELECT al.AuditLogID,
       al.PostedDateTime,
       al.[Event],
       at.TableName,
       ac.ColumnName,
       ald.RowKey,
       al.UserName,
       ald.OldValue,
       ald.NewValue,
       al.HostName,
       al.ApplicationName
FROM   Almis.AuditLogArchive AS al
       INNER JOIN Almis.AuditLogDetailArchive AS  ald
            ON  ald.AuditLogID = al.AuditLogID
       INNER JOIN Almis.AuditTables at
            ON  at.TableID = al.TableID
       INNER JOIN Almis.AuditColumns ac
            ON  ac.ColumnID = ald.ColumnID
