using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using Dapper;
using AutoComplier.UICore.Models.Base;
using AutoComplier.UICore.Models.Request;

namespace AutoComplier.UICore.Controllers
{
    public class ColumnController : ApiController
    {
        [HttpPost]
        public ApiCoreResponse List(ColumnListRequest req)
        {
            ApiCoreResponse apiResponse = new ApiCoreResponse();
            string connectionString = string.Format(@"server={0};uid={1};pwd={2};database={3};", req.server.IP, req.server.User, req.server.Pass, req.server.DefaultDatabase);
            try
            {
                using (IDbConnection conn = new SqlConnection(connectionString))
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
where obj.name=@tableName", new { tableName = req.table.Name }).ToList();
                    apiResponse.Result = columnList;
                    HttpRuntime.Cache.Add("columnList", columnList, null, DateTime.Now.AddSeconds(1200), System.Web.Caching.Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }
            return apiResponse;
        }
    }
}
