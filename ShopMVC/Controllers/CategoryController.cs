using AutoMapper;
using ShopMVC.Models;
using ShopMVC.Servces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopMVC.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ICategoryApiService _categoryApiService;
        private readonly ITovarApiService tovarApiService;
        private readonly IMapper _mapper;
        public CategoryController()
        {
            _categoryApiService = new CategoryApiService();
            tovarApiService = new TovarApiService();
        }

        // GET: Category
        public ActionResult Index()
        {
            var categories = _categoryApiService.CategoryApiServiceGetAll();

            return View(categories);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            var category = _categoryApiService.CategoryApiServiceGetById(id);
            return View(category);
        }

        
        public ActionResult DetailsTovar(int id)
        {
            //var tovars = tovarApiService.TovarApiServiceGetAll();
            //var categories = _categoryApiService.CategoryApiServiceGetAll();
            //tovars = tovars.Where(t=>t.CategoryModelId=categories.Where(c=>c.Id==id));

            //CategoryModels. = db.Players.Where(m => m.TeamId == team.Id);
            //var categoryTovars = _categoryApiService.CategoryTovarsApiServiceGetById(id);
            //return View(categoryTovars);          
            /*
            var products = tovarApiService.TovarApiServiceGetAll();
            var productsModel = _mapper.Map<IEnumerable<TovarModels>>(products);

            if (id != null && id != 0)
            {
                productsModel = productsModel.Where(x => x.CategoryModelId == id);
            }

            var categories = _categoryApiService.CategoryApiServiceGetAll();
            var categoriesModel = _mapper.Map<IEnumerable<CategoryModels>>(categories);

            TovarCategory productsList = new TovarCategory
            {
                Products = productsModel,
                Categories = new SelectList(categoriesModel, "Id", "Name ")
            };

            return View(productsList);
            */
            var category = _categoryApiService.CategoryApiServiceGetById(id);
            var tovars = tovarApiService.TovarApiServiceGetAll();
            //var categories = _categoryApiService.CategoryApiServiceGetAll();

            category.TovarModels = tovars.Where(t => t.CategoryModelId == category.Id);
            return View(category);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
