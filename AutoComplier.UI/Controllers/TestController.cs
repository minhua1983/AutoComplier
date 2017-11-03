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
using AutoComplier.UI.Models.Base;
using AutoComplier.UI.Common;

namespace AutoComplier.UI.Controllers
{
    public class TestController : ApiController
    {
        [HttpPost]
        public ApiResponse Initialize(Server server)
        {
            ApiResponse apiResponse = new ApiResponse();

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
