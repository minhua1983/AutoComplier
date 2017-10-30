using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace AutoComplier.UI.Models.Base
{
    public class Column
    {
        public string Name { get; set; }
        public DbType Type { get; set; }
        public string Length { get; set; }
        public string DefaultValue { get; set; }
        public string Description { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsAllowNull { get; set; }
        public bool IsIdentity { get; set; }
    }
}