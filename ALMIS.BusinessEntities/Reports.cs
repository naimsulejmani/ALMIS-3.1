using System;
using System.Linq.Expressions;

namespace ALMIS.BusinessEntities
{
    public class Reports
    {
        public int AuditLogID { get; set; }
        public DateTime PostedDateTime { get; set; }
        public string Event { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string RowKey { get; set; }
        public string UserName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string HostName { get; set; }
        public string ApplicationName { get; set; }

        public Reports()
        {
            //default konstrutori
        }

        public Reports(int auditLogID, DateTime postedDateTime, string operation, string tableName, string columnName
                       , string rowKey, string userName, string oldValue, string newValue, string hostName,
                       string applicationName)
        {
            AuditLogID = auditLogID;
            PostedDateTime = postedDateTime;
            Event = operation;
            TableName = tableName;
            ColumnName = columnName;
            RowKey = rowKey;
            UserName = userName;
            OldValue = oldValue;
            NewValue = newValue;
            HostName = hostName;
            ApplicationName = applicationName;
        }

        public string GetReportHeader()
        {
            return String.Format("<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}",
                GetMemberName(() => AuditLogID),
                                 GetMemberName(() => PostedDateTime)
                                 , GetMemberName(() => Event), GetMemberName(() => TableName),
                                 GetMemberName(() => ColumnName), GetMemberName(() => RowKey)
                                 , GetMemberName(() => UserName), GetMemberName(() => OldValue),
                                 GetMemberName(() => NewValue), GetMemberName(() => HostName),
                                 GetMemberName(() => ApplicationName));
        }

        public string ToExcelXmlHeader()
        {
            return String.Format("<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">{0}</Data></Cell>" +
                                 "<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">{1}</Data></Cell>" +
                                 "<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">{2}</Data></Cell>" +
                                 "<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">{3}</Data></Cell>" +
                                 "<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">{4}</Data></Cell>" +
                                 "<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">{5}</Data></Cell>" +
                                 "<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">{6}</Data></Cell>" +
                                 "<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">{7}</Data></Cell>" +
                                 "<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">{8}</Data></Cell>" +
                                 "<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">{9}</Data></Cell>" +
                                 "<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">{10}</Data></Cell>",
                                 GetMemberName(() => AuditLogID), GetMemberName(() => PostedDateTime),
                                 GetMemberName(() => Event), GetMemberName(() => TableName),
                                 GetMemberName(() => ColumnName), GetMemberName(() => RowKey),
                                 GetMemberName(() => UserName), GetMemberName(() => OldValue),
                                 GetMemberName(() => NewValue), GetMemberName(() => HostName),
                                 GetMemberName(() => ApplicationName));
        }

        public override string ToString()
        {
            return String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}", AuditLogID, PostedDateTime, Event,
                                 TableName, ColumnName, RowKey, UserName, OldValue, NewValue, HostName, ApplicationName);
        }
        private string GetMemberName<T>(Expression<Func<T>> memberExpression)
        {
            var expressionBody = (MemberExpression)memberExpression.Body;
            return expressionBody.Member.Name;
        }
    }
}
