using RestSharp;
using ShopMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ShopMVC.Servces
{
    public interface ITovarApiService
    {
        IEnumerable<TovarModels> TovarApiServiceGetAll();
        TovarModels TovarApiServiceGetById(int id);
    }


    public class TovarApiService : ITovarApiService
    {
        private readonly RestClient _restClient;
        string urlApi = "api/Tovar";
        public TovarApiService()
        {
            _restClient = new RestClient("http://inetmag.shop/");
        }

        public TovarModels TovarApiServiceGetById(int id)
        {
            StringBuilder urlApiId = new StringBuilder($"{urlApi}" + "/" + $"{id}");
            var requestApi = new RestRequest(urlApi);
            var modelData = _restClient.Execute<List<TovarModels>>(requestApi, Method.GET).Data;
            var modelItem = modelData.FirstOrDefault(x => x.Id == id);
            return modelItem;
        }

        public IEnumerable<TovarModels> TovarApiServiceGetAll()
        {
            var requestApi = new RestRequest(urlApi);
            var modelData = _restClient.Execute<List<TovarModels>>(requestApi, Method.GET).Data;
            return modelData;
        }

    }

}