ALTER TABLE [Almis].[AuditColumns] ADD CONSTRAINT 
fk_AuditColumns_AuditTables_TableID FOREIGN KEY(TableID)  REFERENCES Almis.AuditTables(TableID)
ALTER TABLE [Almis].[AuditColumns] CHECK CONSTRAINT 
[fk_AuditColumns_AuditTables_TableID]
ALTER TABLE [Almis].[AuditLog] ADD  CONSTRAINT [DF_AuditLog_AppName]  DEFAULT(APP_NAME()) 
FOR [ApplicationName]
ALTER TABLE [Almis].[AuditLog] ADD  CONSTRAINT [DF_AuditLog_DateTime]  DEFAULT(GETDATE()) 
FOR [PostedDateTime]
ALTER TABLE [Almis].[AuditLog] ADD  CONSTRAINT [DF_AuditLog_HostName]  DEFAULT(HOST_NAME()) 
FOR [HostName]
ALTER TABLE [Almis].[AuditLog] ADD  CONSTRAINT [DF_AuditLog_UserName]  DEFAULT(SUSER_SNAME()) 
FOR [UserName]
ALTER TABLE [Almis].[AuditLogDetail] ADD  CONSTRAINT [DF_AuditLogDetail_Status]  
DEFAULT((0)) FOR [Status]