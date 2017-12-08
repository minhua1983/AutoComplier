using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoComplier.UICore.Models.Base
{
    public class Table
    {
        public string Name { get; set; }
        public List<Column> ColumnList { get; set; }
    }
}