<%@ WebHandler Language="C#" Class="AutoComplier.UI.Handler0" %>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoComplier.UI
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler0 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World 0");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
		   
		   