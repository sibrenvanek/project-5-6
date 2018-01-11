using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using webshop2.Models;
using Microsoft.AspNet.Identity;

namespace webshop2.Controllers
{
    public class RamController : Controller
    {
        int? ID;
        public ActionResult Index()
        {
            if (Request.HttpMethod == "POST")
            {
                var keys = Request.Form.AllKeys;

                var minPrice = Request.Form.Get(keys[0]);
                var maxPrice = Request.Form.Get(keys[1]);
                var minSize = Request.Form.Get(keys[2]);
                var maxSize = Request.Form.Get(keys[3]);
                string brands, ramType;
                bool check = false;
                try
                {
                    brands = Request.Form.Get(keys[4]);
                    if (brands == "DDR3" || brands == "DDR4")
                    {
                        check = true;
                    }
                }
                catch
                {
                    brands = "";
                }
                try
                {
                    ramType = Request.Form.Get(keys[5]);
                }
                catch
                {
                    ramType = "";
                }
                if (check)
                {
                    ramType = brands;
                    brands = "";
                }

                int? minprice = null, maxprice = null, minsize = null, maxsize = null;
                if (minPrice != "")
                {
                    minprice = Convert.ToInt32(minPrice);
                }
                if (maxPrice != "")
                {
                    maxprice = Convert.ToInt32(maxPrice);
                }
                if (minSize != "")
                {
                    minsize = Convert.ToInt32(minSize);
                }
                if (maxSize != "")
                {
                    maxsize = Convert.ToInt32(maxSize);
                }

                return FilterRam(minprice, maxprice, minsize, maxsize, brands, ramType);
            }
            else
            {
                return FilterRam(null, null, null, null, "", "");
            }

        }
        [WebMethod]
        public ActionResult FilterRam(int? minprice, int? maxprice, int? minsize, int? maxsize, string brands, string ramType)
        {
            using (new_testEntities db = new new_testEntities())
            {
                if (ramType == "")
                {
                    if (brands == "")
                    {
                        if (minprice == null)
                        {
                            if (maxprice == null)
                            {
                                if (minsize == null)
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Ramsize <= maxsize).ToList());
                                    }
                                }
                                else
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Ramsize >= minsize).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Ramsize >= minsize && r.Ramsize <= maxsize).ToList());
                                    }
                                }
                            }
                            else
                            {
                                if (minsize == null)
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price <= maxprice).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price <= maxprice && r.Ramsize <= maxsize).ToList());
                                    }
                                }
                                else
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price <= maxprice && r.Ramsize >= minsize).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price <= maxprice && r.Ramsize >= minsize && r.Ramsize <= maxsize).ToList());
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (maxprice == null)
                            {
                                if (minsize == null)
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Ramsize <= maxsize).ToList());
                                    }
                                }
                                else
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Ramsize >= minsize).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Ramsize >= minsize && r.Ramsize <= maxsize).ToList());
                                    }
                                }
                            }
                            else
                            {
                                if (minsize == null)
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Price <= maxprice).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Price <= maxprice && r.Ramsize <= maxsize).ToList());
                                    }
                                }
                                else
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Price <= maxprice && r.Ramsize >= minsize).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Price <= maxprice && r.Ramsize >= minsize && r.Ramsize <= maxsize).ToList());
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (minprice == null)
                        {
                            if (maxprice == null)
                            {
                                if (minsize == null)
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Brand == brands).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Ramsize <= maxsize && r.Brand == brands).ToList());
                                    }
                                }
                                else
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Ramsize >= minsize && r.Brand == brands).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Ramsize >= minsize && r.Ramsize <= maxsize && r.Brand == brands).ToList());
                                    }
                                }
                            }
                            else
                            {
                                if (minsize == null)
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price <= maxprice && r.Brand == brands).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price <= maxprice && r.Ramsize <= maxsize && r.Brand == brands).ToList());
                                    }
                                }
                                else
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price <= maxprice && r.Ramsize >= minsize && r.Brand == brands).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price <= maxprice && r.Ramsize >= minsize && r.Ramsize <= maxsize && r.Brand == brands).ToList());
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (maxprice == null)
                            {
                                if (minsize == null)
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Brand == brands).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Ramsize <= maxsize && r.Brand == brands).ToList());
                                    }
                                }
                                else
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Ramsize >= minsize && r.Brand == brands).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Ramsize >= minsize && r.Ramsize <= maxsize && r.Brand == brands).ToList());
                                    }
                                }
                            }
                            else
                            {
                                if (minsize == null)
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Price <= maxprice && r.Brand == brands).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Price <= maxprice && r.Ramsize <= maxsize && r.Brand == brands).ToList());
                                    }
                                }
                                else
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Price <= maxprice && r.Ramsize >= minsize && r.Brand == brands).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Price <= maxprice && r.Ramsize >= minsize && r.Ramsize <= maxsize && r.Brand == brands).ToList());
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (brands == "")
                    {
                        if (minprice == null)
                        {
                            if (maxprice == null)
                            {
                                if (minsize == null)
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.MemoryType == ramType).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Ramsize <= maxsize && r.MemoryType == ramType).ToList());
                                    }
                                }
                                else
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Ramsize >= minsize && r.MemoryType == ramType).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Ramsize >= minsize && r.Ramsize <= maxsize && r.MemoryType == ramType).ToList());
                                    }
                                }
                            }
                            else
                            {
                                if (minsize == null)
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price <= maxprice && r.MemoryType == ramType).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price <= maxprice && r.Ramsize <= maxsize && r.MemoryType == ramType).ToList());
                                    }
                                }
                                else
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price <= maxprice && r.Ramsize >= minsize && r.MemoryType == ramType).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price <= maxprice && r.Ramsize >= minsize && r.Ramsize <= maxsize && r.MemoryType == ramType).ToList());
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (maxprice == null)
                            {
                                if (minsize == null)
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.MemoryType == ramType).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Ramsize <= maxsize && r.MemoryType == ramType).ToList());
                                    }
                                }
                                else
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Ramsize >= minsize && r.MemoryType == ramType).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Ramsize >= minsize && r.Ramsize <= maxsize && r.MemoryType == ramType).ToList());
                                    }
                                }
                            }
                            else
                            {
                                if (minsize == null)
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Price <= maxprice && r.MemoryType == ramType).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Price <= maxprice && r.Ramsize <= maxsize && r.MemoryType == ramType).ToList());
                                    }
                                }
                                else
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Price <= maxprice && r.Ramsize >= minsize && r.MemoryType == ramType).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Price <= maxprice && r.Ramsize >= minsize && r.Ramsize <= maxsize && r.MemoryType == ramType).ToList());
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if (minprice == null)
                        {
                            if (maxprice == null)
                            {
                                if (minsize == null)
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Brand == brands && r.MemoryType == ramType).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Ramsize <= maxsize && r.Brand == brands && r.MemoryType == ramType).ToList());
                                    }
                                }
                                else
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Ramsize >= minsize && r.Brand == brands && r.MemoryType == ramType).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Ramsize >= minsize && r.Ramsize <= maxsize && r.Brand == brands && r.MemoryType == ramType).ToList());
                                    }
                                }
                            }
                            else
                            {
                                if (minsize == null)
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price <= maxprice && r.Brand == brands && r.MemoryType == ramType).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price <= maxprice && r.Ramsize <= maxsize && r.Brand == brands && r.MemoryType == ramType).ToList());
                                    }
                                }
                                else
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price <= maxprice && r.Ramsize >= minsize && r.Brand == brands && r.MemoryType == ramType).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price <= maxprice && r.Ramsize >= minsize && r.Ramsize <= maxsize && r.Brand == brands && r.MemoryType == ramType).ToList());
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (maxprice == null)
                            {
                                if (minsize == null)
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Brand == brands && r.MemoryType == ramType).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Ramsize <= maxsize && r.Brand == brands && r.MemoryType == ramType).ToList());
                                    }
                                }
                                else
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Ramsize >= minsize && r.Brand == brands && r.MemoryType == ramType).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Ramsize >= minsize && r.Ramsize <= maxsize && r.Brand == brands && r.MemoryType == ramType).ToList());
                                    }
                                }
                            }
                            else
                            {
                                if (minsize == null)
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Price <= maxprice && r.Brand == brands && r.MemoryType == ramType).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Price <= maxprice && r.Ramsize <= maxsize && r.Brand == brands && r.MemoryType == ramType).ToList());
                                    }
                                }
                                else
                                {
                                    if (maxsize == null)
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Price <= maxprice && r.Ramsize >= minsize && r.Brand == brands && r.MemoryType == ramType).ToList());
                                    }
                                    else
                                    {
                                        return View(db.ram.Where(r => r.Price >= minprice && r.Price <= maxprice && r.Ramsize >= minsize && r.Ramsize <= maxsize && r.Brand == brands && r.MemoryType == ramType).ToList());
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public ActionResult FilterRam(string searchstring)
        {
            using(new_testEntities db = new new_testEntities())
            {
                var data = db.ram.Where(r => r.Name.Contains(searchstring) || r.Brand.Contains(searchstring)).ToList();
                return View(data);
            }
        }
        // GET: Image
        [HttpGet]
        public ActionResult View(int? id)
        {
            ram ram = new ram();
            ID = id;
            using (new_testEntities db = new new_testEntities())
            {
                //db.product.Add(new product
                //{
                //    ID = id,
                //    price = 80,
                //    imagepath = "~/images/ram/ram1.jpg",
                //    stock = 100,
                //    Brand = "Kingston",
                //    Supplier = "testsupplier"
                //});
                //db.SaveChanges();
                //product product = db.product.FirstOrDefault(x => x.ID == id);
                //db.ram.Add(new ram
                //{
                //    ID = product.ID,
                //    Brand = "Kingston",
                //    CompositionOfMemory = "1x",
                //    MemoryType = "DDR3",
                //    Clockspeed = 2133,
                //    CASlatency = 15,
                //    Voltage = (float)1.2 ,
                //    MemoryModuleConnection = 1,
                //    MemorySuitableFor = "Desktop",
                //    ImagePath = "~/images/ram/ram1.jpg",
                //    Name = "Kingston123",
                //    Price = 80,
                //    Ramsize = 8
                //});

                //db.SaveChanges();

                ram = db.ram.Where(x => x.ID == ID).FirstOrDefault();
            }
            return View(ram);
        }
        //[HttpGet]
        public ActionResult Add_To_Wishlist(int id)
        {
            //Console.WriteLine("Add to wishlist is succesfully called");
            ID = id;


            using (new_testEntities db = new new_testEntities())
            {

                //user user = db.user.FirstOrDefault(x => x.ID == id);
                product product = db.product.FirstOrDefault(x => x.ID == id);
                wishlist Wishlist = db.wishlist.FirstOrDefault(x => x.ProductId == id);

                if (Wishlist == null)
                {

                    db.wishlist.Add(new wishlist { ProductId = product.ID, /*UserId = user.ID,*/ Quantity = 1, ProductName = product.ProductName, Price = product.price, Imagepath = product.imagepath });
                    db.SaveChanges();
                }
                else
                {
                    Wishlist.Quantity += 1;
                    db.SaveChanges();
                }

                return RedirectToAction("View/" + ID, "Ram");
            }

        }
        public ActionResult Add_To_Shoppingcart(int id)
        {
            //Console.WriteLine("Add to wishlist is succesfully called");
            ID = id;


            using (new_testEntities db = new new_testEntities())
            {

                //user user = db.user.FirstOrDefault(x => x.ID == id);
                product product = db.product.FirstOrDefault(x => x.ID == id);
                shoppingcart shoppingcart = db.shoppingcart.FirstOrDefault(x => x.ProductId == id);

                if (shoppingcart == null)
                {

                    db.shoppingcart.Add(new shoppingcart {
                        ProductId = product.ID, /*UserId = user.ID,*/ Quantity = 1, ProductName = product.ProductName, Price = (decimal)0.0, Imagepath = product.imagepath });
                    db.SaveChanges();
                }
                else
                {
                    shoppingcart.Quantity += 1;
                    db.SaveChanges();
                }

                return RedirectToAction("View/" + ID, "Ram");
            }
        }
        public ActionResult search()
        {
            var nvc = Request.Form;
            string searchstring = nvc["searchstring"];
            return FilterRam(searchstring);
        }
    }
}