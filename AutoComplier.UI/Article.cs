//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoComplier.UI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Article
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public int Amount { get; set; }
        public double Cost { get; set; }
        public int IsDeleted { get; set; }
    
        public virtual Section Section { get; set; }
    }
}
