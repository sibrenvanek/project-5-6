﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webshop2.Models;
using System.Web.Helpers;

namespace webshop2.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics
        public ActionResult Index()
        {
            List<product> listproducts = new List<product>();

            using (new_testEntities db = new new_testEntities())
            {
                listproducts = db.product.ToList();

            }

                return View(listproducts);
        }
        public ActionResult ShowChart()
        {


            using (new_testEntities db = new new_testEntities())
            {
                List<string> listproductnames = new List<string>();
                List<string> listproductpurchasedquantity = new List<string>();
                foreach (product p in db.product)
                {
                    if (p.PurchasedQuantity > 0)
                    {
                        listproductnames.Add(p.ProductName.ToString());
                        listproductpurchasedquantity.Add(p.PurchasedQuantity.ToString());
                    }
                }
                var chart = new Chart(width: 600, height: 400)
                    .AddSeries(
                            chartType: "bar",
                            xValue: listproductnames,
                            yValues: listproductpurchasedquantity)
                            .GetBytes("png");

                return File(chart, "image/bytes");
            }
        }

        // GET: Statistics/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Statistics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Statistics/Create
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

        // GET: Statistics/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Statistics/Edit/5
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

        // GET: Statistics/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Statistics/Delete/5
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
