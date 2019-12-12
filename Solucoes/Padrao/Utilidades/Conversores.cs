using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Utilidades
{
    public static class Conversores
    {
        #region String para outros formatos

        public static int ToInt(this string value)
        {
            value.Treat();

            var output = 0;
            int.TryParse(value, out output);

            return output;
        }

        public static decimal ToDecimal(this string value)
        {
            value.Treat();

            var output = 0m;
            decimal.TryParse(value, out output);

            return output;
        }

        public static double ToDouble(this string value)
        {
            value.Treat();

            var output = 0d;
            double.TryParse(value, out output);

            return output;
        }

        public static long ToLong(this string value)
        {
            value.Treat();

            var output = 0L;
            long.TryParse(value, out output);

            return output;
        }

        #endregion

        #region Tratamento de nullables

        public static string Treat(this string value)
        {
            value = (value ?? "").Trim().ToUpper();
            return value;
        }

        #endregion

        #region Verifica existência de valores

        public static bool HasValue(this string value)
        {
            value = value.Treat();
            return value.Trim().Length > 0;
        }

        #endregion

        public static Type ToCSharpType(this object sqlType, bool nullable)
        {
            switch (sqlType == null ? "" : sqlType.ToString())
            {
                case "bigint":
                    return nullable ? typeof(long?) : typeof(long);

                case "binary":
                case "image":
                case "timestamp":
                case "varbinary":
                    return typeof(byte[]);

                case "bit":
                    return nullable ? typeof(bool?) : typeof(bool);

                case "char":
                case "nChar":
                case "ntext":
                case "nvarchar":
                case "text":
                case "varchar":
                case "xml":
                    return typeof(string);

                case "datetime":
                case "smalldatetime":
                case "date":
                case "time":
                case "datetime2":
                    return nullable ? typeof(DateTime?) : typeof(DateTime);

                case "decimal":
                case "money":
                case "smallmoney":
                    return nullable ? typeof(decimal?) : typeof(decimal);

                case "float":
                    return nullable ? typeof(double?) : typeof(double);

                case "int":
                    return nullable ? typeof(int?) : typeof(int);

                case "real":
                    return nullable ? typeof(float?) : typeof(float);

                case "uniqueidentifier":
                    return nullable ? typeof(Guid?) : typeof(Guid);

                case "smallint":
                    return nullable ? typeof(short?) : typeof(short);

                case "tinyint":
                    return nullable ? typeof(byte?) : typeof(byte);

                case "variant":
                case "udt":
                    return typeof(object);

                case "structured":
                    return typeof(DataTable);

                case "datetimeoffset":
                    return nullable ? typeof(DateTimeOffset?) : typeof(DateTimeOffset);

                default:
                    return typeof(string);
            }
        }

        public static IQueryable ToIQueryable<T>(this GridView gridView)
        {
            return gridView.ToGridList<T>().AsQueryable();
        }

        public static List<T> ToGridList<T>(this GridView gridView)
        {
            if (gridView == null)
                return null;

            var data = new List<T>();

            for (int a = 0; a < gridView.DataRowCount; a++)
                data.Add((T)gridView.GetRow(a));

            return data;
        }

        public static DataTable ToDataTable<T>(this GridView gridView)
        {
            return ToDataTable<T>(gridView.ToIQueryable<T>().Cast<T>());
        }

        public static DataTable ToDataTable<T>(this IQueryable<T> varlist)
        {
            DataTable dtReturn = new DataTable();

            // column names 
            PropertyInfo[] oProps = null;

            if (varlist == null) return dtReturn;

            foreach (T rec in varlist)
            {
                // Use reflection to get property names, to create table, Only first time, others  will follow 
                if (oProps == null)
                {
                    oProps = ((Type)rec.GetType()).GetProperties();
                    foreach (PropertyInfo pi in oProps)
                    {
                        Type colType = pi.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                    }
                }

                DataRow dr = dtReturn.NewRow();

                foreach (PropertyInfo pi in oProps)
                {
                    var ret = pi.GetValue(rec, null);
                    dr[pi.Name] = ret == null ? DBNull.Value : ret;
                }

                dtReturn.Rows.Add(dr);
            }
            return dtReturn;
        }

        public static DataSet ToDataSet<T>(this IList<T> list)
        {
            Type elementType = typeof(T);
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            ds.Tables.Add(t);

            //add a column to table for each public property on T
            foreach (var propInfo in elementType.GetProperties())
            {
                Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;

                t.Columns.Add(propInfo.Name, ColType);
            }

            //go through each property on T and add each value to the table
            foreach (T item in list)
            {
                DataRow row = t.NewRow();

                foreach (var propInfo in elementType.GetProperties())
                {
                    row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                }

                t.Rows.Add(row);
            }

            return ds;
        }


        public static Stream ToStream(this XtraReport report)
        {
            var stream = new MemoryStream();
            report.SaveLayout(stream);

            return stream;
        }

        public static Stream ToStream(this string param)
        {
            return new MemoryStream(Encoding.UTF8.GetBytes(param));
        }

        public static XtraReport ToXtraReport(this Stream report)
        {
            return XtraReport.FromStream((MemoryStream)report, true);
        }

        public static XtraReport ToXtraReport(this string report)
        {
            return ToXtraReport(ToStream(report));
        }

        public static string Save(this XtraReport report)
        {
            var stream = new MemoryStream();
            report.SaveLayoutToXml(stream);

            stream.Position = 0;
            return new StreamReader(stream).ReadToEnd();
        }
    }
}