
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
	public partial class ArticleRepository
	{
		string connectionString = ConfigurationManager.AppSettings["demo"];

		public List<Article> List()
		{
			List<Article> result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				result = conn.Query<Article>("SELECT * FROM Article").AsList();
			}
			return result;
		}

		public Article Detail(int id)
		{
			Article result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				result = conn.Query<Article>("SELECT * FROM Article WHERE id=@id",new { id = id }).FirstOrDefault();
			}
			return result;
		}

		public Article Insert(Article model)
		{
			
			Article result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				object identity = conn.ExecuteScalar<Article>("INSERT INTO Article VALUES(ISNULL(@SectionId,),ISNULL(@Title,),ISNULL(@CreateDate,(getdate())),ISNULL(@Amount,((1))),ISNULL(@Cost,((0))),ISNULL(@IsDeleted,((0))));SELECT SCOPE_IDENTITY();", model);
				int id = int.Parse(identity.ToString());
				result = Detail(id);
			}
			return result;
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
				result = conn.Query<Section>("SELECT * FROM Section").AsList();
			}
			return result;
		}

		public Section Detail(int id)
		{
			Section result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				result = conn.Query<Section>("SELECT * FROM Section WHERE id=@id",new { id = id }).FirstOrDefault();
			}
			return result;
		}

		public Section Insert(Section model)
		{
			
			Section result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				object identity = conn.ExecuteScalar<Section>("INSERT INTO Section VALUES(ISNULL(@Title,),ISNULL(@CreateDate,(getdate())));SELECT SCOPE_IDENTITY();", model);
				int id = int.Parse(identity.ToString());
				result = Detail(id);
			}
			return result;
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
				result = conn.Query<User>("SELECT * FROM User").AsList();
			}
			return result;
		}

		public User Detail(int id)
		{
			User result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				result = conn.Query<User>("SELECT * FROM User WHERE id=@id",new { id = id }).FirstOrDefault();
			}
			return result;
		}

		public User Insert(User model)
		{
			
			User result;
			using(IDbConnection conn = new SqlConnection(connectionString))
			{
				object identity = conn.ExecuteScalar<User>("INSERT INTO User VALUES(ISNULL(@UserName,),ISNULL(@CreateDate,(getdate())));SELECT SCOPE_IDENTITY();", model);
				int id = int.Parse(identity.ToString());
				result = Detail(id);
			}
			return result;
		}
	}
}