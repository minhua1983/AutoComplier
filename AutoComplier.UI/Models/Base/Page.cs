using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoComplier.UI.Models.Base
{
    public class Page
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public int RecordCount { get; set; }
    }
}