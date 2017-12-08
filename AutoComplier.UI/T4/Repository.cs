
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using Dapper;
using AutoComplier.UI.Models;

namespace AutoComplier.UI.Repositories
{
	//生成时间：2017/12/8 15:27:48
	public partial class ArticleRepository
	{
		string connectionString = ConfigurationManager.AppSettings["demo"];

		public List<Article> List()
		{
			List<Article> result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				result = conn.Query<Article>("SELECT * FROM [Article]").AsList();
			}
			return result;
		}

		public Article Detail(int identity)
		{
			Article result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				result = conn.Query<Article>("SELECT * FROM [Article] WHERE [Id] = @Id",new { Id = identity }).FirstOrDefault();
			}
			return result;
		}

		public Article Insert(Article model)
		{
			
			Article result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				object identityColumn = conn.ExecuteScalar("INSERT INTO [Article]([SectionId],[Title],[CreateDate],[Amount],[Cost],[IsDeleted]) VALUES(@SectionId,@Title,@CreateDate,@Amount,@Cost,@IsDeleted);SELECT SCOPE_IDENTITY();", model);
				int identity = int.Parse(identityColumn.ToString());
				result = Detail(identity);
			}
			return result;
		}

		public Article Update(Article model)
		{
			
			Article result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				conn.Execute("UPDATE [Article] SET [SectionId] = ISNULL(@SectionId,[SectionId]),[Title] = ISNULL(@Title,[Title]),[CreateDate] = ISNULL(@CreateDate,[CreateDate]),[Amount] = ISNULL(@Amount,[Amount]),[Cost] = ISNULL(@Cost,[Cost]),[IsDeleted] = ISNULL(@IsDeleted,[IsDeleted]) WHERE [Id] = @Id", model);
				result = Detail(model.Id.Value);
			}
			return result;
		}

		public void Delete(int identity)
		{
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				conn.Execute("DELETE FROM [Article] WHERE [Id] = @Id", new { Id = identity });
			}
		}
	}
	public partial class Class1Repository
	{
		string connectionString = ConfigurationManager.AppSettings["demo"];

		public List<Class1> List()
		{
			List<Class1> result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				result = conn.Query<Class1>("SELECT * FROM [Class1]").AsList();
			}
			return result;
		}

		public Class1 Detail(int identity)
		{
			Class1 result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				result = conn.Query<Class1>("SELECT * FROM [Class1] WHERE [id] = @id",new { id = identity }).FirstOrDefault();
			}
			return result;
		}

		public Class1 Insert(Class1 model)
		{
			
			Class1 result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				object identityColumn = conn.ExecuteScalar("INSERT INTO [Class1]([title],[desc]) VALUES(@title,@desc);SELECT SCOPE_IDENTITY();", model);
				int identity = int.Parse(identityColumn.ToString());
				result = Detail(identity);
			}
			return result;
		}

		public Class1 Update(Class1 model)
		{
			
			Class1 result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				conn.Execute("UPDATE [Class1] SET [title] = ISNULL(@title,[title]),[desc] = ISNULL(@desc,[desc]) WHERE [id] = @id", model);
				result = Detail(model.id.Value);
			}
			return result;
		}

		public void Delete(int identity)
		{
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				conn.Execute("DELETE FROM [Class1] WHERE [id] = @id", new { id = identity });
			}
		}
	}
	public partial class DemoRepository
	{
		string connectionString = ConfigurationManager.AppSettings["demo"];

		public List<Demo> List()
		{
			List<Demo> result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				result = conn.Query<Demo>("SELECT * FROM [Demo]").AsList();
			}
			return result;
		}

		public Demo Detail(int identity)
		{
			Demo result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				result = conn.Query<Demo>("SELECT * FROM [Demo] WHERE [id] = @id",new { id = identity }).FirstOrDefault();
			}
			return result;
		}

		public Demo Insert(Demo model)
		{
			
			Demo result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				object identityColumn = conn.ExecuteScalar("INSERT INTO [Demo]([title],[create_date],[is_deleted]) VALUES(@title,@create_date,@is_deleted);SELECT SCOPE_IDENTITY();", model);
				int identity = int.Parse(identityColumn.ToString());
				result = Detail(identity);
			}
			return result;
		}

		public Demo Update(Demo model)
		{
			
			Demo result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				conn.Execute("UPDATE [Demo] SET [title] = ISNULL(@title,[title]),[create_date] = ISNULL(@create_date,[create_date]),[is_deleted] = ISNULL(@is_deleted,[is_deleted]) WHERE [id] = @id", model);
				result = Detail(model.id.Value);
			}
			return result;
		}

		public void Delete(int identity)
		{
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				conn.Execute("DELETE FROM [Demo] WHERE [id] = @id", new { id = identity });
			}
		}
	}
	public partial class SectionRepository
	{
		string connectionString = ConfigurationManager.AppSettings["demo"];

		public List<Section> List()
		{
			List<Section> result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				result = conn.Query<Section>("SELECT * FROM [Section]").AsList();
			}
			return result;
		}

		public Section Detail(int identity)
		{
			Section result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				result = conn.Query<Section>("SELECT * FROM [Section] WHERE [Id] = @Id",new { Id = identity }).FirstOrDefault();
			}
			return result;
		}

		public Section Insert(Section model)
		{
			
			Section result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				object identityColumn = conn.ExecuteScalar("INSERT INTO [Section]([Title],[CreateDate]) VALUES(@Title,@CreateDate);SELECT SCOPE_IDENTITY();", model);
				int identity = int.Parse(identityColumn.ToString());
				result = Detail(identity);
			}
			return result;
		}

		public Section Update(Section model)
		{
			
			Section result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				conn.Execute("UPDATE [Section] SET [Title] = ISNULL(@Title,[Title]),[CreateDate] = ISNULL(@CreateDate,[CreateDate]) WHERE [Id] = @Id", model);
				result = Detail(model.Id.Value);
			}
			return result;
		}

		public void Delete(int identity)
		{
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				conn.Execute("DELETE FROM [Section] WHERE [Id] = @Id", new { Id = identity });
			}
		}
	}
	public partial class TrailerRepository
	{
		string connectionString = ConfigurationManager.AppSettings["demo"];

		public List<Trailer> List()
		{
			List<Trailer> result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				result = conn.Query<Trailer>("SELECT * FROM [Trailer]").AsList();
			}
			return result;
		}

		public Trailer Detail(int identity)
		{
			Trailer result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				result = conn.Query<Trailer>("SELECT * FROM [Trailer] WHERE [id] = @id",new { id = identity }).FirstOrDefault();
			}
			return result;
		}

		public Trailer Insert(Trailer model)
		{
			
			Trailer result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				object identityColumn = conn.ExecuteScalar("INSERT INTO [Trailer]([title],[create_time],[is_deleted]) VALUES(@title,@create_time,@is_deleted);SELECT SCOPE_IDENTITY();", model);
				int identity = int.Parse(identityColumn.ToString());
				result = Detail(identity);
			}
			return result;
		}

		public Trailer Update(Trailer model)
		{
			
			Trailer result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				conn.Execute("UPDATE [Trailer] SET [title] = ISNULL(@title,[title]),[create_time] = ISNULL(@create_time,[create_time]),[is_deleted] = ISNULL(@is_deleted,[is_deleted]) WHERE [id] = @id", model);
				result = Detail(model.id.Value);
			}
			return result;
		}

		public void Delete(int identity)
		{
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				conn.Execute("DELETE FROM [Trailer] WHERE [id] = @id", new { id = identity });
			}
		}
	}
	public partial class UserRepository
	{
		string connectionString = ConfigurationManager.AppSettings["demo"];

		public List<User> List()
		{
			List<User> result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				result = conn.Query<User>("SELECT * FROM [User]").AsList();
			}
			return result;
		}

		public User Detail(int identity)
		{
			User result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				result = conn.Query<User>("SELECT * FROM [User] WHERE [Id] = @Id",new { Id = identity }).FirstOrDefault();
			}
			return result;
		}

		public User Insert(User model)
		{
			
			User result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				object identityColumn = conn.ExecuteScalar("INSERT INTO [User]([UserName],[CreateDate]) VALUES(@UserName,@CreateDate);SELECT SCOPE_IDENTITY();", model);
				int identity = int.Parse(identityColumn.ToString());
				result = Detail(identity);
			}
			return result;
		}

		public User Update(User model)
		{
			
			User result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				conn.Execute("UPDATE [User] SET [UserName] = ISNULL(@UserName,[UserName]),[CreateDate] = ISNULL(@CreateDate,[CreateDate]) WHERE [Id] = @Id", model);
				result = Detail(model.Id.Value);
			}
			return result;
		}

		public void Delete(int identity)
		{
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				conn.Execute("DELETE FROM [User] WHERE [Id] = @Id", new { Id = identity });
			}
		}
	}
}