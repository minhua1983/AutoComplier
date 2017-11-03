
using System;

namespace AutoComplier.UI.Models
{
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
	public class Faker
	{
		public Nullable<Int32> Id{ get;set; }
		public String Title{ get;set; }
		public Nullable<DateTime> CreateDate{ get;set; }
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