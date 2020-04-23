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
        CategoryModels CategoryApiServiceGetById(int id);
        //TovarModels CategoryTovarsApiServiceGetById(int id);
    }


    public class CategoryApiService : ICategoryApiService
    {
        private readonly RestClient _restClient;
        string urlApi = "api/Category";
        public CategoryApiService()
        {
            _restClient = new RestClient("http://inetmag.shop/");
        }


        public IEnumerable<CategoryModels> CategoryApiServiceGetAll()
        {
            
            var requestApi = new RestRequest(urlApi);
            var modelData = _restClient.Execute<List<CategoryModels>>(requestApi, Method.GET).Data;
            return modelData;
        }

        public CategoryModels CategoryApiServiceGetById(int id)
        {
            var requestApi = new RestRequest(urlApi);
            var modelData = _restClient.Execute<List<CategoryModels>>(requestApi, Method.GET).Data;
            var modelItem = modelData.FirstOrDefault(x => x.Id == id);
            return modelItem;
        }

        //public TovarModels CategoryTovarsApiServiceGetById(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}