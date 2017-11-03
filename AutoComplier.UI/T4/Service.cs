
using System;
using System.Collections.Generic;
using AutoComplier.UI.Repositories;
using AutoComplier.UI.Models;

namespace AutoComplier.UI.Services
{
	public partial class ArticleService
	{
		ArticleRepository repository = new ArticleRepository();

		public List<Article> List()
		{
			return repository.List();
		}

		public Article Insert(Article model)
		{
			return repository.Insert(model);
		}
	}
	public partial class SectionService
	{
		SectionRepository repository = new SectionRepository();

		public List<Section> List()
		{
			return repository.List();
		}

		public Section Insert(Section model)
		{
			return repository.Insert(model);
		}
	}
	public partial class UserService
	{
		UserRepository repository = new UserRepository();

		public List<User> List()
		{
			return repository.List();
		}

		public User Insert(User model)
		{
			return repository.Insert(model);
		}
	}
}