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
using AutoComplier.UICore.Common;

namespace AutoComplier.UICore.Controllers
{
    public class TestController : ApiController
    {
        [HttpPost]
        public ApiCoreResponse Initialize(Server server)
        {
            ApiCoreResponse apiResponse = new ApiCoreResponse();

            try
            {
                apiResponse.Result = TableHelper.List(server);
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
