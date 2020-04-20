using ShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopAPI.Controllers
{
    public class TovarController : ApiController
    {

        List<TovarApiModel> list;
        public TovarController()
        {
            list = new List<TovarApiModel>
            {
                new TovarApiModel{Id=1,Name="ashdjshahkjdksjf",Price=500,CategoryId=1 },
                new TovarApiModel{Id=2,Name="qwtyetywqewyury",Price=1000,CategoryId=2 },
                new TovarApiModel{Id=3,Name="zxcnbzxvxcz",Price=750,CategoryId=1 }
            };
        }

        // GET: api/Tovar
        public IEnumerable<TovarApiModel> Get()
        {
            return list;
        }

        // GET: api/Tovar/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tovar
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Tovar/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Tovar/5
        public void Delete(int id)
        {
        }
    }
}
