using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace reportadoami.Controllers
{
    public class dashboardClienteController : Controller
    {
        // GET: dashboardCliente
        public ActionResult Index()
        {
            return View();
        }

        // GET: dashboardCliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: dashboardCliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: dashboardCliente/Create
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

        // GET: dashboardCliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: dashboardCliente/Edit/5
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

        // GET: dashboardCliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: dashboardCliente/Delete/5
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
