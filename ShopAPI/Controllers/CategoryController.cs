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
    public class CategoryController : ApiController
    {
        /*
        List<CategoryApiModel> list;
        public CategoryController()
        {
            list = new List<CategoryApiModel>
            {
                new CategoryApiModel{Id=1,Name="a1111111111"},
                new CategoryApiModel{Id=2,Name="b2222222222"},
                new CategoryApiModel{Id=3,Name="c3333333333"}
            };
        }
        */

        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }


        // GET: api/Category
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(_categoryService.GetAll());
            //return list;
        }

        // GET: api/Category/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Category
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Category/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
        }
    }
}
