using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using Dapper;
using AutoComplier.UI.Models.Base;

namespace AutoComplier.UI.Controllers
{
    public class ServerController : ApiController
    {
        [HttpPost]
        public ApiResponse Connect(Server server)
        {
            ApiResponse api = new ApiResponse();
            string connectionString = string.Format(@"server={0};uid={1};pwd={2};database=master;", server.IP, server.User, server.Pass);

            return api;
        }
    }
}
