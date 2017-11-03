﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace AutoComplier.UI.Models.Base
{
    public class Column
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Length { get; set; }
        public string DefaultValue { get; set; }
        public string Description { get; set; }
        public bool IsNullable { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsIdentity { get; set; }

    }
}