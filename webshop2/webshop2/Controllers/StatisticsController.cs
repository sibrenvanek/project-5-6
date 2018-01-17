using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webshop2.Models;
using System.Web.Helpers;
using Microsoft.AspNet.Identity;

namespace webshop2.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics
        public ActionResult Index()
        {
            List<product> listproducts = new List<product>();


            using (ApplicationDbContext db2 = new ApplicationDbContext())
            {
                if (User.IsInRole("Admin"))
                {

                    using (new_testEntities db = new new_testEntities())
                    {
                        listproducts = db.product.ToList();

                    }
                }
            
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
                                    chartType: "column",
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
                using (ApplicationDbContext db2 = new ApplicationDbContext())
                {
                    if (User.IsInRole("Admin"))
                    {


                        // TODO: Add insert logic here
                        using (new_testEntities db = new new_testEntities())
                        {
                            product p = new product
                            {
                                price = Convert.ToDecimal(collection[11]),
                                imagepath = collection[9],
                                stock = 100,
                                Brand = collection[1],
                                Supplier = "testsupplier",
                                ProductName = collection[10]
                            };
                            ram r = new ram
                            {
                                ID = p.ID,
                                Brand = p.Brand,
                                CompositionOfMemory = collection[2],
                                MemoryType = collection[3],
                                Clockspeed = Convert.ToInt32(collection[4]),
                                CASlatency = Convert.ToInt32(collection[5]),
                                Voltage = (float)Convert.ToDouble(collection[6]),
                                MemoryModuleConnection = Convert.ToInt32(collection[7]),
                                MemorySuitableFor = collection[8],
                                ImagePath = p.imagepath,
                                Name = p.ProductName,
                                Price = p.price,
                                Ramsize = Convert.ToInt32(collection[12])
                            };
                            db.product.Add(p);
                            db.ram.Add(r);
                            db.SaveChanges();
                        }
                    }
                }
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
            using (ApplicationDbContext db2 = new ApplicationDbContext())
            {
                ram ram = new ram();
                if (User.IsInRole("Admin"))
                {


                    using (new_testEntities db = new new_testEntities())
                    {
                        ram = db.ram.FirstOrDefault(r => r.ID == id);
                        
                    }
                }
                return View(ram);
            }
        }

        // POST: Statistics/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                using (ApplicationDbContext db2 = new ApplicationDbContext())
                {

                    if (User.IsInRole("Admin"))
                    {
                        using (new_testEntities db = new new_testEntities())
                        {
                            // TODO: Add update logic here
                            ram ram = db.ram.FirstOrDefault(r => r.ID == id);
                            product product = db.product.FirstOrDefault(p => p.ID == id);
                            ram.ImagePath = collection[10];
                            product.imagepath = collection[10];
                            ram.Brand = collection[2];
                            product.Brand = collection[2];
                            ram.CompositionOfMemory = collection[3];
                            ram.MemoryType = collection[4];
                            ram.Clockspeed = Convert.ToInt32(collection[5]);
                            ram.CASlatency = Convert.ToInt32(collection[6]);
                            ram.Voltage = (float)Convert.ToDouble(collection[7]);
                            ram.MemoryModuleConnection = Convert.ToInt32(collection[8]);
                            ram.MemorySuitableFor = collection[9];
                            ram.Name = collection[11];
                            product.ProductName = collection[11];
                            ram.Price = Convert.ToDecimal(collection[12]);
                            product.price = Convert.ToDecimal(collection[12]);
                            ram.Ramsize = Convert.ToInt32(collection[13]);

                            db.SaveChanges();

                            
                        }
                    }
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Statistics/Delete/5
        public ActionResult Delete(int id)
        {
            using (ApplicationDbContext db2 = new ApplicationDbContext())
            {

                if (User.IsInRole("Admin"))
                {
                    using (new_testEntities db = new new_testEntities())
                    {
                        ram ram = db.ram.FirstOrDefault(r => r.ID == id);
                        product product = db.product.FirstOrDefault(p => p.ID == id);
                        db.ram.Remove(ram);
                        db.product.Remove(product);
                        db.SaveChanges();
                    }
                }
            }
            return RedirectToAction("Index");
        }
    }
}
