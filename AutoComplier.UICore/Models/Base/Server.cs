using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoComplier.UICore.Models.Base
{
    public class Server
    {
        public string IP { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public string DefaultDatabase { get; set; }
    }
}