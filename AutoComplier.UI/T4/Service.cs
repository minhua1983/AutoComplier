

using System;
using System.Collections.Generic;
using AutoComplier.UI.Repositories;
using AutoComplier.UI.Models;
using AutoComplier.UI.Models.Base;
namespace AutoComplier.UI.Services
{
	//生成时间：2017/12/8 16:11:51
	public partial class ArticleService
	{
		ArticleRepository repository = new ArticleRepository();

		public List<Article> List(Page page)
		{
			return repository.List();
		}

		public Article Detail(int identity)
		{
			return repository.Detail(identity);
		}

		public Article Insert(Article model)
		{
			return repository.Insert(model);
		}

		public Article Update(Article model)
		{
			return repository.Update(model);
		}

		public void Delete(int identity)
		{
			repository.Delete(identity);
		}
	}
	public partial class Class1Service
	{
		Class1Repository repository = new Class1Repository();

		public List<Class1> List(Page page)
		{
			return repository.List();
		}

		public Class1 Detail(int identity)
		{
			return repository.Detail(identity);
		}

		public Class1 Insert(Class1 model)
		{
			return repository.Insert(model);
		}

		public Class1 Update(Class1 model)
		{
			return repository.Update(model);
		}

		public void Delete(int identity)
		{
			repository.Delete(identity);
		}
	}
	public partial class DemoService
	{
		DemoRepository repository = new DemoRepository();

		public List<Demo> List(Page page)
		{
			return repository.List();
		}

		public Demo Detail(int identity)
		{
			return repository.Detail(identity);
		}

		public Demo Insert(Demo model)
		{
			return repository.Insert(model);
		}

		public Demo Update(Demo model)
		{
			return repository.Update(model);
		}

		public void Delete(int identity)
		{
			repository.Delete(identity);
		}
	}
	public partial class SectionService
	{
		SectionRepository repository = new SectionRepository();

		public List<Section> List(Page page)
		{
			return repository.List();
		}

		public Section Detail(int identity)
		{
			return repository.Detail(identity);
		}

		public Section Insert(Section model)
		{
			return repository.Insert(model);
		}

		public Section Update(Section model)
		{
			return repository.Update(model);
		}

		public void Delete(int identity)
		{
			repository.Delete(identity);
		}
	}
	public partial class TrailerService
	{
		TrailerRepository repository = new TrailerRepository();

		public List<Trailer> List(Page page)
		{
			return repository.List();
		}

		public Trailer Detail(int identity)
		{
			return repository.Detail(identity);
		}

		public Trailer Insert(Trailer model)
		{
			return repository.Insert(model);
		}

		public Trailer Update(Trailer model)
		{
			return repository.Update(model);
		}

		public void Delete(int identity)
		{
			repository.Delete(identity);
		}
	}
	public partial class UserService
	{
		UserRepository repository = new UserRepository();

		public List<User> List(Page page)
		{
			return repository.List();
		}

		public User Detail(int identity)
		{
			return repository.Detail(identity);
		}

		public User Insert(User model)
		{
			return repository.Insert(model);
		}

		public User Update(User model)
		{
			return repository.Update(model);
		}

		public void Delete(int identity)
		{
			repository.Delete(identity);
		}
	}
}