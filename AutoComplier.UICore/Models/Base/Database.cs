using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoComplier.UICore.Models.Base
{
    public class Database
    {
        public string Name { get; set; }
        public List<Table> TableList { get; set; }
    }
}