using System;
using System.Collections.Generic;

namespace AutoComplier.UICore.Models.Base
{
    public class ApiCoreResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public dynamic Result { get; set; }
    }
}