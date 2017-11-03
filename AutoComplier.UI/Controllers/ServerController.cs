﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using Dapper;
using AutoComplier.UI.Models.Base;

namespace AutoComplier.UI.Controllers
{
    public class ServerController : ApiController
    {
        [HttpPost]
        public ApiResponse Connect(Server server)
        {
            ApiResponse apiResponse = new ApiResponse();
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