using AutoMapper;
using ShopAPI.Models;
using ShopBLL.Interfaces;
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
        /*
        List<TovarApiModel> list;
        public TovarController()
        {
            list = new List<TovarApiModel>
            {
                new TovarApiModel{Id=1,Name="ashdjshahkjdksjf",Price=500,CategoryApiModelId=1 },
                new TovarApiModel{Id=2,Name="qwtyetywqewyury",Price=1000,CategoryApiModelId=2 },
                new TovarApiModel{Id=3,Name="zxcnbzxvxcz",Price=750,CategoryApiModelId=1 }
            };
        }
        */

        private readonly ITovarService _tovarService;
        private readonly IMapper _mapper;

        public TovarController(ITovarService tovarService, IMapper mapper)
        {
            _mapper = mapper;
            _tovarService = tovarService;
        }


        // GET: api/Tovar
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(_tovarService.GetAll());

            //return list;
        }

        // GET: api/Tovar/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            return Ok(_tovarService.GetById(id));
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
