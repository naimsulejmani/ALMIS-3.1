using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using BE = ALMIS.BusinessEntities.Reports;

namespace ALMIS.Viewer.App_Code
{
    public class ExcelExport
    {
        public static void ExportToExcel(DataSet source, string fileName)
        {
            var excelDoc = new StreamWriter(fileName);
            const string startExcelXml = "<xml version>\r\n<Workbook " +
                  "xmlns=\"urn:schemas-microsoft-com:office:spreadsheet\"\r\n" +
                  " xmlns:o=\"urn:schemas-microsoft-com:office:office\"\r\n " +
                  "xmlns:x=\"urn:schemas-    microsoft-com:office:" +
                  "excel\"\r\n xmlns:ss=\"urn:schemas-microsoft-com:" +
                  "office:spreadsheet\">\r\n <Styles>\r\n " +
                  "<Style ss:ID=\"Default\" ss:Name=\"Normal\">\r\n " +
                  "<Alignment ss:Vertical=\"Bottom\"/>\r\n <Borders/>" +
                  "\r\n <Font/>\r\n <Interior/>\r\n <NumberFormat/>" +
                  "\r\n <Protection/>\r\n </Style>\r\n " +
                  "<Style ss:ID=\"BoldColumn\">\r\n <Font " +
                  "x:Family=\"Swiss\" ss:Bold=\"1\"/>\r\n </Style>\r\n " +
                  "<Style     ss:ID=\"StringLiteral\">\r\n <NumberFormat" +
                  " ss:Format=\"@\"/>\r\n </Style>\r\n <Style " +
                  "ss:ID=\"Decimal\">\r\n <NumberFormat " +
                  "ss:Format=\"0.0000\"/>\r\n </Style>\r\n " +
                  "<Style ss:ID=\"Integer\">\r\n <NumberFormat " +
                  "ss:Format=\"0\"/>\r\n </Style>\r\n <Style " +
                  "ss:ID=\"DateLiteral\">\r\n <NumberFormat " +
                  "ss:Format=\"mm/dd/yyyy;@\"/>\r\n </Style>\r\n " +
                  "</Styles>\r\n ";
            const string endExcelXml = "</Workbook>";

            int rowCount = 0;
            int sheetCount = 1;
            /*
           <xml version>
           <Workbook xmlns="urn:schemas-microsoft-com:office:spreadsheet"
           xmlns:o="urn:schemas-microsoft-com:office:office"
           xmlns:x="urn:schemas-microsoft-com:office:excel"
           xmlns:ss="urn:schemas-microsoft-com:office:spreadsheet">
           <Styles>
           <Style ss:ID="Default" ss:Name="Normal">
             <Alignment ss:Vertical="Bottom"/>
             <Borders/>
             <Font/>
             <Interior/>
             <NumberFormat/>
             <Protection/>
           </Style>
           <Style ss:ID="BoldColumn">
             <Font x:Family="Swiss" ss:Bold="1"/>
           </Style>
           <Style ss:ID="StringLiteral">
             <NumberFormat ss:Format="@"/>
           </Style>
           <Style ss:ID="Decimal">
             <NumberFormat ss:Format="0.0000"/>
           </Style>
           <Style ss:ID="Integer">
             <NumberFormat ss:Format="0"/>
           </Style>
           <Style ss:ID="DateLiteral">
             <NumberFormat ss:Format="mm/dd/yyyy;@"/>
           </Style>
           </Styles>
           <Worksheet ss:Name="Sheet1">
           </Worksheet>
           </Workbook>
           */
            excelDoc.Write(startExcelXml);
            excelDoc.Write("<Worksheet ss:Name=\"Sheet" + sheetCount + "\">");
            excelDoc.Write("<Table>");
            excelDoc.Write("<Row>");
            for (int x = 0; x < source.Tables[0].Columns.Count; x++)
            {
                excelDoc.Write("<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">");
                excelDoc.Write(source.Tables[0].Columns[x].ColumnName);
                excelDoc.Write("</Data></Cell>");
            }
            excelDoc.Write("</Row>");
            foreach (DataRow x in source.Tables[0].Rows)
            {
                rowCount++;
                //if the number of rows is > 64000 create a new page to continue output
                if (rowCount == 64000)
                {
                    rowCount = 0;
                    sheetCount++;
                    excelDoc.Write("</Table>");
                    excelDoc.Write(" </Worksheet>");
                    excelDoc.Write("<Worksheet ss:Name=\"Sheet" + sheetCount + "\">");
                    excelDoc.Write("<Table>");
                }
                excelDoc.Write("<Row>"); //ID=" + rowCount + "
                for (int y = 0; y < source.Tables[0].Columns.Count; y++)
                {
                    Type rowType = x[y].GetType();
                    switch (rowType.ToString())
                    {
                        case "System.String":
                            string xmLstring = x[y].ToString();
                            xmLstring = xmLstring.Trim();
                            xmLstring = xmLstring.Replace("&", "&");
                            xmLstring = xmLstring.Replace(">", ">");
                            xmLstring = xmLstring.Replace("<", "<");
                            excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                           "<Data ss:Type=\"String\">");
                            excelDoc.Write(xmLstring);
                            excelDoc.Write("</Data></Cell>");
                            break;
                        case "System.DateTime":
                            //Excel has a specific Date Format of YYYY-MM-DD followed by  
                            //the letter 'T' then hh:mm:sss.lll Example 2005-01-31T24:01:21.000
                            //The Following Code puts the date stored in XMLDate 
                            //to the format above
                            var xmlDate = (DateTime)x[y];
                            string xmlDatetoString = string.Format("{0}-{1}-{2}T{3}:{4}:{5}.000",
                                                                   xmlDate.Year.ToString(CultureInfo.InvariantCulture),
                                                                   (xmlDate.Month < 10
                                                                        ? "0" +
                                                                          xmlDate.Month.ToString(
                                                                              CultureInfo.InvariantCulture)
                                                                        : xmlDate.Month.ToString(
                                                                            CultureInfo.InvariantCulture)),
                                                                   (xmlDate.Day < 10
                                                                        ? "0" +
                                                                          xmlDate.Day.ToString(
                                                                              CultureInfo.InvariantCulture)
                                                                        : xmlDate.Day.ToString(
                                                                            CultureInfo.InvariantCulture)),
                                                                   (xmlDate.Hour < 10
                                                                        ? "0" +
                                                                          xmlDate.Hour.ToString(
                                                                              CultureInfo.InvariantCulture)
                                                                        : xmlDate.Hour.ToString(
                                                                            CultureInfo.InvariantCulture)),
                                                                   (xmlDate.Minute < 10
                                                                        ? "0" +
                                                                          xmlDate.Minute.ToString(
                                                                              CultureInfo.InvariantCulture)
                                                                        : xmlDate.Minute.ToString(
                                                                            CultureInfo.InvariantCulture)),
                                                                   (xmlDate.Second < 10
                                                                        ? "0" +
                                                                          xmlDate.Second.ToString(
                                                                              CultureInfo.InvariantCulture)
                                                                        : xmlDate.Second.ToString(
                                                                            CultureInfo.InvariantCulture)));
                            excelDoc.Write("<Cell ss:StyleID=\"DateLiteral\">" +
                                         "<Data ss:Type=\"DateTime\">");
                            excelDoc.Write(xmlDatetoString);
                            excelDoc.Write("</Data></Cell>");
                            break;
                        case "System.Boolean":
                            excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                        "<Data ss:Type=\"String\">");
                            excelDoc.Write(x[y].ToString());
                            excelDoc.Write("</Data></Cell>");
                            break;
                        case "System.Int16":
                        case "System.Int32":
                        case "System.Int64":
                        case "System.Byte":
                            excelDoc.Write("<Cell ss:StyleID=\"Integer\">" +
                                    "<Data ss:Type=\"Number\">");
                            excelDoc.Write(x[y].ToString());
                            excelDoc.Write("</Data></Cell>");
                            break;
                        case "System.Decimal":
                        case "System.Double":
                            excelDoc.Write("<Cell ss:StyleID=\"Decimal\">" +
                                  "<Data ss:Type=\"Number\">");
                            excelDoc.Write(x[y].ToString());
                            excelDoc.Write("</Data></Cell>");
                            break;
                        case "System.DBNull":
                            excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                  "<Data ss:Type=\"String\">");
                            excelDoc.Write("");
                            excelDoc.Write("</Data></Cell>");
                            break;
                        default:
                            throw (new Exception(rowType + " not handled."));
                    }
                }
                excelDoc.Write("</Row>");
            }
            excelDoc.Write("</Table>");
            excelDoc.Write(" </Worksheet>");
            excelDoc.Write(endExcelXml);
            excelDoc.Close();
        }

        public static void ExportToExcel(List<BE> reports, string fileName)
        {
            var excelDoc = new StreamWriter(fileName);
            const string startExcelXml = "<xml version>\r\n<Workbook " +
                  "xmlns=\"urn:schemas-microsoft-com:office:spreadsheet\"\r\n" +
                  " xmlns:o=\"urn:schemas-microsoft-com:office:office\"\r\n " +
                  "xmlns:x=\"urn:schemas-    microsoft-com:office:" +
                  "excel\"\r\n xmlns:ss=\"urn:schemas-microsoft-com:" +
                  "office:spreadsheet\">\r\n <Styles>\r\n " +
                  "<Style ss:ID=\"Default\" ss:Name=\"Normal\">\r\n " +
                  "<Alignment ss:Vertical=\"Bottom\"/>\r\n <Borders/>" +
                  "\r\n <Font/>\r\n <Interior/>\r\n <NumberFormat/>" +
                  "\r\n <Protection/>\r\n </Style>\r\n " +
                  "<Style ss:ID=\"BoldColumn\">\r\n <Font " +
                  "x:Family=\"Swiss\" ss:Bold=\"1\"/>\r\n </Style>\r\n " +
                  "<Style     ss:ID=\"StringLiteral\">\r\n <NumberFormat" +
                  " ss:Format=\"@\"/>\r\n </Style>\r\n <Style " +
                  "ss:ID=\"Decimal\">\r\n <NumberFormat " +
                  "ss:Format=\"0.0000\"/>\r\n </Style>\r\n " +
                  "<Style ss:ID=\"Integer\">\r\n <NumberFormat " +
                  "ss:Format=\"0\"/>\r\n </Style>\r\n <Style " +
                  "ss:ID=\"DateLiteral\">\r\n <NumberFormat " +
                  "ss:Format=\"mm/dd/yyyy;@\"/>\r\n </Style>\r\n " +
                  "</Styles>\r\n ";
            const string endExcelXml = "</Workbook>";

           // int rowCount = 0;
            const int sheetCount = 1;
            //start of document
            excelDoc.Write(startExcelXml);
            //start of sheet
            excelDoc.Write("<Worksheet ss:Name=\"Sheet" + sheetCount + "\">");
            //start of table
            excelDoc.Write("<Table>");
            //start of row
            excelDoc.Write("<Row>");
            //inside of row
            string reportsHeaders = reports[0].ToExcelXmlHeader();
            excelDoc.WriteLine(reportsHeaders);
            //end of row
            excelDoc.Write("</Row>");
            //foreach row on list do...
            foreach (var report in reports)
            {
                excelDoc.Write("<Row>");
                //AuditLogID
                excelDoc.Write("<Cell ss:StyleID=\"Integer\">" +
                                    "<Data ss:Type=\"Number\">");
                excelDoc.Write(report.AuditLogID);
                excelDoc.Write("</Data></Cell>");
                //PostedDateTime
                var xmlDate = report.PostedDateTime;
                string xmlDatetoString = string.Format("{0}-{1}-{2}T{3}:{4}:{5}.000",
                                                       xmlDate.Year.ToString(CultureInfo.InvariantCulture),
                                                       (xmlDate.Month < 10
                                                            ? "0" +
                                                              xmlDate.Month.ToString(
                                                                  CultureInfo.InvariantCulture)
                                                            : xmlDate.Month.ToString(
                                                                CultureInfo.InvariantCulture)),
                                                       (xmlDate.Day < 10
                                                            ? "0" +
                                                              xmlDate.Day.ToString(
                                                                  CultureInfo.InvariantCulture)
                                                            : xmlDate.Day.ToString(
                                                                CultureInfo.InvariantCulture)),
                                                       (xmlDate.Hour < 10
                                                            ? "0" +
                                                              xmlDate.Hour.ToString(
                                                                  CultureInfo.InvariantCulture)
                                                            : xmlDate.Hour.ToString(
                                                                CultureInfo.InvariantCulture)),
                                                       (xmlDate.Minute < 10
                                                            ? "0" +
                                                              xmlDate.Minute.ToString(
                                                                  CultureInfo.InvariantCulture)
                                                            : xmlDate.Minute.ToString(
                                                                CultureInfo.InvariantCulture)),
                                                       (xmlDate.Second < 10
                                                            ? "0" +
                                                              xmlDate.Second.ToString(
                                                                  CultureInfo.InvariantCulture)
                                                            : xmlDate.Second.ToString(
                                                                CultureInfo.InvariantCulture)));
                excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                             "<Data ss:Type=\"String\">");
                excelDoc.Write(xmlDatetoString);
                excelDoc.Write("</Data></Cell>");
                //Event
                excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                           "<Data ss:Type=\"String\">");
                excelDoc.Write(report.Event);
                excelDoc.Write("</Data></Cell>");
                //TableName
                excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                           "<Data ss:Type=\"String\">");
                excelDoc.Write(report.TableName);
                excelDoc.Write("</Data></Cell>");
                //ColumnName
                excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                           "<Data ss:Type=\"String\">");
                excelDoc.Write(report.ColumnName);
                excelDoc.Write("</Data></Cell>");
                //RowKey
                excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                           "<Data ss:Type=\"String\">");
                excelDoc.Write(report.RowKey);
                excelDoc.Write("</Data></Cell>");
                //Username
                excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                           "<Data ss:Type=\"String\">");
                excelDoc.Write(report.UserName);
                excelDoc.Write("</Data></Cell>");
                //OldValue
                excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                           "<Data ss:Type=\"String\">");
                excelDoc.Write(report.OldValue);
                excelDoc.Write("</Data></Cell>");
                //NewValue
                excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                           "<Data ss:Type=\"String\">");
                excelDoc.Write(report.NewValue);
                excelDoc.Write("</Data></Cell>");
                //Hostname
                excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                           "<Data ss:Type=\"String\">");
                excelDoc.Write(report.HostName);
                excelDoc.Write("</Data></Cell>");
                //ApplicationName
                excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                           "<Data ss:Type=\"String\">");
                excelDoc.Write(report.ApplicationName);
                excelDoc.Write("</Data></Cell>");
                //end of row
                excelDoc.Write("</Row>");

            }
            //end of table
            excelDoc.Write("</Table>");
            //end of worksheet
            excelDoc.Write("</Worksheet>");
            //end of document
            excelDoc.Write(endExcelXml);
            //close document and save
            excelDoc.Close();
        }
    }
}
