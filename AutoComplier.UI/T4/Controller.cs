
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
    public partial class ArticleController : ApiController
    {
		ArticleService service = new ArticleService();

        [HttpGet]
        public List<Article> Test()
        {
            return service.List();;
        }

		/*
		[HttpGet]
        public ApiResponse List()
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.List();
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }
		//*/

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
    }
    public partial class SectionController : ApiController
    {
		SectionService service = new SectionService();

        [HttpGet]
        public List<Section> Test()
        {
            return service.List();;
        }

		/*
		[HttpGet]
        public ApiResponse List()
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.List();
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }
		//*/

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
    }
    public partial class UserController : ApiController
    {
		UserService service = new UserService();

        [HttpGet]
        public List<User> Test()
        {
            return service.List();;
        }

		/*
		[HttpGet]
        public ApiResponse List()
        {
            ApiResponse apiResponse = new ApiResponse();

            try
            {
                apiResponse.Result = service.List();
            }
            catch (Exception ex)
            {
                apiResponse.Code = 1;
                apiResponse.Message = ex.Message;
            }

            return apiResponse;
        }
		//*/

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
    }
}