

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoComplier.UI.Models;
using AutoComplier.UI.Models.Base;
using AutoComplier.UI.Services;

namespace AutoComplier.UI.Controllers
{
	//生成时间：2017/12/8 16:11:54
    public partial class ArticleController : ApiController
    {
		ArticleService service = new ArticleService();

		/*
        [HttpGet]
        public List<Article> Test()
        {
            return service.List();;
        }
		//*/
		
		[HttpGet]
        public ApiResponse List(Page page)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.List(page);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpGet]
        public ApiResponse Detail(int identity)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.Detail(identity);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpPost]
        public ApiResponse Insert(Article model)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.Insert(model);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpPost]
        public ApiResponse Update(Article model)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.Update(model);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpPost]
        public ApiResponse Delete(int identity)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                service.Delete(identity);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }
    }
    public partial class Class1Controller : ApiController
    {
		Class1Service service = new Class1Service();

		/*
        [HttpGet]
        public List<Class1> Test()
        {
            return service.List();;
        }
		//*/
		
		[HttpGet]
        public ApiResponse List(Page page)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.List(page);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpGet]
        public ApiResponse Detail(int identity)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.Detail(identity);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpPost]
        public ApiResponse Insert(Class1 model)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.Insert(model);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpPost]
        public ApiResponse Update(Class1 model)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.Update(model);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpPost]
        public ApiResponse Delete(int identity)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                service.Delete(identity);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }
    }
    public partial class DemoController : ApiController
    {
		DemoService service = new DemoService();

		/*
        [HttpGet]
        public List<Demo> Test()
        {
            return service.List();;
        }
		//*/
		
		[HttpGet]
        public ApiResponse List(Page page)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.List(page);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpGet]
        public ApiResponse Detail(int identity)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.Detail(identity);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpPost]
        public ApiResponse Insert(Demo model)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.Insert(model);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpPost]
        public ApiResponse Update(Demo model)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.Update(model);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpPost]
        public ApiResponse Delete(int identity)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                service.Delete(identity);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }
    }
    public partial class SectionController : ApiController
    {
		SectionService service = new SectionService();

		/*
        [HttpGet]
        public List<Section> Test()
        {
            return service.List();;
        }
		//*/
		
		[HttpGet]
        public ApiResponse List(Page page)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.List(page);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpGet]
        public ApiResponse Detail(int identity)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.Detail(identity);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpPost]
        public ApiResponse Insert(Section model)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.Insert(model);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpPost]
        public ApiResponse Update(Section model)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.Update(model);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpPost]
        public ApiResponse Delete(int identity)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                service.Delete(identity);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }
    }
    public partial class TrailerController : ApiController
    {
		TrailerService service = new TrailerService();

		/*
        [HttpGet]
        public List<Trailer> Test()
        {
            return service.List();;
        }
		//*/
		
		[HttpGet]
        public ApiResponse List(Page page)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.List(page);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpGet]
        public ApiResponse Detail(int identity)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.Detail(identity);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpPost]
        public ApiResponse Insert(Trailer model)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.Insert(model);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpPost]
        public ApiResponse Update(Trailer model)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.Update(model);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpPost]
        public ApiResponse Delete(int identity)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                service.Delete(identity);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }
    }
    public partial class UserController : ApiController
    {
		UserService service = new UserService();

		/*
        [HttpGet]
        public List<User> Test()
        {
            return service.List();;
        }
		//*/
		
		[HttpGet]
        public ApiResponse List(Page page)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.List(page);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpGet]
        public ApiResponse Detail(int identity)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.Detail(identity);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpPost]
        public ApiResponse Insert(User model)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.Insert(model);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpPost]
        public ApiResponse Update(User model)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.Update(model);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }

		[HttpPost]
        public ApiResponse Delete(int identity)
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                service.Delete(identity);
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }
    }
}