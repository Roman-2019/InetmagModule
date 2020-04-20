using ShopMVC.Servces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopMVC.Controllers
{
    public class TovarController : Controller
    {

        private readonly TovarApiService _tovarApiService;
        public TovarController()
        {
            _tovarApiService = new TovarApiService();
        }


        // GET: Tovar
        public ActionResult Index()
        {
            var tovars = _tovarApiService.TovarApiServiceGetAll();

            return View(tovars);
        }

        // GET: Tovar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tovar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tovar/Create
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

        // GET: Tovar/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tovar/Edit/5
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

        // GET: Tovar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tovar/Delete/5
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
