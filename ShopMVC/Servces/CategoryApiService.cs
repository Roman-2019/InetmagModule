using RestSharp;
using ShopMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopMVC.Servces
{
    public interface ICategoryApiService
    {
        IEnumerable<CategoryMvcModel> CategoryApiServiceGetAll();
    }


    public class CategoryApiService : ICategoryApiService
    {
        private readonly RestClient _restClient;
        public CategoryApiService()
        {
            _restClient = new RestClient("https://inetmag.shop/");
        }


        public IEnumerable<CategoryMvcModel> CategoryApiServiceGetAll()
        {
            var urlApi = "api/Category/";
            var requestApi = new RestRequest(urlApi);
            var modelData = _restClient.Execute<List<CategoryMvcModel>>(requestApi, Method.GET).Data;
            return modelData;
        }
    }
}