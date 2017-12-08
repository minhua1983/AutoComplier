using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using AutoComplier.UICore.Models.Base;

namespace AutoComplier.UICore.Common
{
    public class TableHelper
    {
        public static List<Table> List(Server server)
        {

            List<Table> tableList = new List<Table>();
            string targetConnectionString = string.Format(@"server={0};uid={1};pwd={2};database={3};", server.IP, server.User, server.Pass, server.DefaultDatabase);
            
            using (IDbConnection conn = new SqlConnection(targetConnectionString))
            {
                conn.Open();
                tableList = conn.Query<Table>("SELECT name FROM sysobjects WHERE type = 'U' ORDER BY name").ToList();
                conn.Close();
            }

            tableList.ForEach(table =>
            {
                using (IDbConnection conn = new SqlConnection(targetConnectionString))
                {
                    conn.Open();
                    List<Column> columnList = conn.Query<Column>(@"select  
col.name as Name,  
col.isnullable as IsNullable,  
col.length as Length,  
tp.name as Type,  
ep.value as Description,  
com.text as DefaultValue,
(  
    select count(*) from sys.sysobjects  
    where parent_obj=obj.id  
    and name=(  
        select top 1 name from sys.sysindexes ind  
        inner join sys.sysindexkeys indkey  
        on ind.indid=indkey.indid  
        and indkey.colid=col.colid  
        and indkey.id=obj.id  
        where ind.id=obj.id  
        and ind.name like 'PK_%'  
    )  
) as IsPrimaryKey  
,  
COLUMNPROPERTY(col.id,col.name,'IsIdentity') as IsIdentity  
from sys.sysobjects obj  
inner join sys.syscolumns col  
on obj.id = col.id  
left join syscomments com
on col.cdefault= com.id
left join sys.systypes tp  
on col.xtype=tp.xusertype  
left join sys.extended_properties ep  
on ep.major_id=obj.id  
and ep.minor_id=col.colid  
and ep.name='MS_Description'  
where obj.name=@tableName", new { tableName = table.Name }).ToList();
                    table.ColumnList = columnList;
                    conn.Close();
                }
            });
            return tableList;

        }
    }
}