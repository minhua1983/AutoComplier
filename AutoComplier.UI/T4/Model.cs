
using System;

namespace AutoComplier.UI.Models
{
	//生成时间：2017/11/7 18:18:14
	public class Article
	{
		public Nullable<Int32> Id{ get;set; }
		public Nullable<Int32> SectionId{ get;set; }
		public String Title{ get;set; }
		public Nullable<DateTime> CreateDate{ get;set; }
		public Nullable<Int32> Amount{ get;set; }
		public Nullable<Single> Cost{ get;set; }
		public Nullable<Int32> IsDeleted{ get;set; }
	}
	public class Demo
	{
		public Nullable<Int32> id{ get;set; }
		public String title{ get;set; }
		public Nullable<DateTime> create_date{ get;set; }
		public Nullable<Boolean> is_deleted{ get;set; }
	}
	public class Section
	{
		public Nullable<Int32> Id{ get;set; }
		public String Title{ get;set; }
		public Nullable<DateTime> CreateDate{ get;set; }
	}
	public class User
	{
		public Nullable<Int32> Id{ get;set; }
		public String UserName{ get;set; }
		public Nullable<DateTime> CreateDate{ get;set; }
	}
 
}