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
        //IEnumerable<TovarModels> GetByCategory(int id);
        //TovarModels TovarCategoryApiServiceGetAll(int id);
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
            //var urlApi = "api/Tovar/";
            //var requestApi = new RestRequest(urlApi, Method.GET);
            //var modelData = _restClient.Execute<List<TovarMvcModel>>(requestApi).Data;

            var requestApi = new RestRequest(urlApi);
            var modelData = _restClient.Execute<List<TovarModels>>(requestApi, Method.GET).Data;
            return modelData;
        }

        //public IEnumerable<TovarModels> GetByCategory(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public TovarModels TovarCategoryApiServiceGetAll(int id)
        //{
        //    var requestApi = new RestRequest(urlApi);
        //    var modelData = _restClient.Execute<List<TovarModels>>(requestApi, Method.GET).Data;
        //    var modelItem = modelData.Where(c => c.CategoryModelId == id);
        //    return modelItem;
        //}
    }

}