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
        IList<TovarModels> TovarApiServiceGetAll();
    }


    public class TovarApiService : ITovarApiService
    {
        private readonly RestClient _restClient;
        public TovarApiService()
        {
            _restClient = new RestClient("http://inetmag.shop/");
        }


        public IList<TovarModels> TovarApiServiceGetAll()
        {
            var urlApi = "api/Tovar/";
            //var requestApi = new RestRequest(urlApi, Method.GET);
            //var modelData = _restClient.Execute<List<TovarMvcModel>>(requestApi).Data;

            var requestApi = new RestRequest(urlApi);
            var modelData = _restClient.Execute<List<TovarModels>>(requestApi, Method.GET).Data;
            return modelData;
        }
    }

}