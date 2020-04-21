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
        IEnumerable<CategoryModels> CategoryApiServiceGetAll();
    }


    public class CategoryApiService : ICategoryApiService
    {
        private readonly RestClient _restClient;
        public CategoryApiService()
        {
            _restClient = new RestClient("http://inetmag.shop/");
        }


        public IEnumerable<CategoryModels> CategoryApiServiceGetAll()
        {
            var urlApi = "api/Category/";
            var requestApi = new RestRequest(urlApi);
            var modelData = _restClient.Execute<List<CategoryModels>>(requestApi, Method.GET).Data;
            return modelData;
        }
    }
}