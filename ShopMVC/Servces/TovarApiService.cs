using RestSharp;
using ShopMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopMVC.Servces
{
    public interface ITovarApiService
    {
        IList<TovarMvcModel> TovarApiServiceGetAll();
    }


    public class TovarApiService : ITovarApiService
    {
        private readonly RestClient _restClient;
        public TovarApiService()
        {
            _restClient = new RestClient("https://inetmag.shop/");
        }


        public IList<TovarMvcModel> TovarApiServiceGetAll()
        {
            var urlApi = "api/Tovar/";
            //var requestApi = new RestRequest(urlApi, Method.GET);
            //var modelData = _restClient.Execute<List<TovarMvcModel>>(requestApi).Data;

            var requestApi = new RestRequest(urlApi);
            var modelData = _restClient.Execute<List<TovarMvcModel>>(requestApi, Method.GET).Data;
            return modelData;
        }
    }

}