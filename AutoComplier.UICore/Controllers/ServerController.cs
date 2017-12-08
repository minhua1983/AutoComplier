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

namespace AutoComplier.UICore.Controllers
{
    public class ServerController : ApiController
    {
        [HttpPost]
        public ApiCoreResponse Connect(Server server)
        {
            ApiCoreResponse apiResponse = new ApiCoreResponse();
            string connectionString = string.Format(@"server={0};uid={1};pwd={2};database=master;", server.IP, server.User, server.Pass);
            try
            {
                using (IDbConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    HttpRuntime.Cache.Add("Server", server, null, DateTime.Now.AddSeconds(1200), System.Web.Caching.Cache.NoSlidingExpiration,System.Web.Caching.CacheItemPriority.Normal,null);
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
