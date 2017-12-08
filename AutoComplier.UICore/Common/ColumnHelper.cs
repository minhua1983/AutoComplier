using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace AutoComplier.UICore.Common
{
    public class ColumnHelper
    {
        public static string ConvertToMetaTypeString(string sqlDbType)
        {
            DbType dbType = DbType.String;

            switch (sqlDbType.ToLower())
            {
                case "int":
                    dbType = DbType.Int32;
                    break;
                case "varchar":
                    dbType = DbType.String;
                    break;
                case "bit":
                    dbType = DbType.Boolean;
                    break;
                case "datetime":
                    dbType = DbType.DateTime;
                    break;
                case "decimal":
                    dbType = DbType.Decimal;
                    break;
                case "float":
                    dbType = DbType.Single;
                    break;
                //case "image":
                //    dbType = DbType.Image;
                //    break;
                //case "money":
                //    dbType = DbType.Money;
                //    break;
                case "ntext":
                    dbType = DbType.String;
                    break;
                case "nvarchar":
                    dbType = DbType.String;
                    break;
                case "smalldatetime":
                    dbType = DbType.DateTime;
                    break;
                case "smallint":
                    dbType = DbType.Int16;
                    break;
                case "text":
                    dbType = DbType.String;
                    break;
                case "bigint":
                    dbType = DbType.Int64;
                    break;
                case "binary":
                    dbType = DbType.String;
                    break;
                case "char":
                    dbType = DbType.String;
                    break;
                case "nchar":
                    dbType = DbType.String;
                    break;
                case "numeric":
                    dbType = DbType.Decimal;
                    break;
                //case "real":
                //    dbType = DbType.Real;
                //    break;
                //case "smallmoney":
                //    dbType = SqlDbType.SmallMoney;
                //    break;
                //case "sql_variant":
                //    dbType = SqlDbType.Variant;
                //    break;
                case "timestamp":
                    dbType = DbType.Byte;
                    break;
                //case "tinyint":
                //    dbType = SqlDbType.TinyInt;
                //    break;
                case "uniqueidentifier":
                    dbType = DbType.Guid;
                    break;
                //case "varbinary":
                //    dbType = SqlDbType.VarBinary;
                //    break;
                case "xml":
                    dbType = DbType.Xml;
                    break;
            }
            if (dbType == DbType.String) return dbType.ToString();
            if (dbType == DbType.Byte) return "object";
            return @"Nullable<" + dbType.ToString() + ">";
        }
    }
}