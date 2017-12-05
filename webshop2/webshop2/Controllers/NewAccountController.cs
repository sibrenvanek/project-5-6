using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webshop2.Models;

namespace webshop2.Controllers
{
    public class NewAccountController : Controller
    {
        // GET: NewAccount
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// encrypts a string using a code
        /// </summary>
        /// <param name="s">string to encrypt</param>
        /// <param name="code">code to encrypt the string with</param>
        /// <returns>encrypted string</returns>
        public static string Encrypt(string s, int code)
        {
            string encryptedS = "";
            foreach (char c in s)
            {
                int C = Convert.ToInt32(c);
                C += code;
                while (C > 126)
                {
                    C -= 94;
                }
                char encryptedC = Convert.ToChar(C);
                encryptedS += encryptedC;
            }
            return encryptedS;
        }

        /// <summary>
        /// decrypts an encrypted string using a code
        /// </summary>
        /// <param name="s">string to decrypt</param>
        /// <param name="code">code to decrypt the string with</param>
        /// <returns>decrypted string</returns>
        public static string Decrypt(string s, int code)
        {
            string decryptedS = "";
            foreach (char c in s)
            {
                int C = Convert.ToInt32(c);
                C -= code;
                while (C < 32)
                {
                    C += 94;
                }
                decryptedS += Convert.ToChar(C);
            }
            return decryptedS;
        }


        // GET: NewAccount/Create
        [HttpPost]
        public ActionResult Register(RegisterViewModel model)

        {
            int code = new Random().Next(0, 100);
            string username = model.Username;
            string name = Encrypt(model.Firstname + " " + model.Lastname, code);
            string dateofbirth = model.DateOfBirth;
            DateTime dateOfBirth = Convert.ToDateTime(dateofbirth);//new DateTime(Convert.ToInt32(dateofbirth[6] + dateofbirth[7] + dateofbirth[8] + dateofbirth[9]), Convert.ToInt32(dateofbirth[3] + dateofbirth[4]), Convert.ToInt32(dateofbirth[0] + dateofbirth[1]));
            string email = model.Email;
            string password = Encrypt(model.Password, code);
            string postcode = model.Postcode;
            int housenumber = Convert.ToInt32(model.Housenumber);
            string extension = model.Extension;
            if (extension == null)
            {
                extension = "";
            }
            string street = model.Street;
            string city = model.City;
            string phonenumber = model.Phonenumber;
            if (phonenumber != null)
            {
                phonenumber = Encrypt(phonenumber, code);
            }
            string addres = Encrypt(name + "\n" + street + " " + housenumber.ToString() + extension + "\n" + postcode + ", " + city, code);
            IdentityResult result = IdentityResult.Failed();
            using (new_testEntities db = new new_testEntities())
            {
                bool check = true;
                foreach (user u in db.user)
                {
                    if (u.Email == email)
                    {
                        check = false;
                    }
                }
                if (check)
                {
                    db.user.Add(new user { code = code, username = username, name = name, dateofbirth = dateofbirth, Email = email, password = password, adress = addres, phonenumber = phonenumber });

                    db.SaveChanges();
                    result = IdentityResult.Success;
                }
                else
                {
                    result = IdentityResult.Failed("Email already in use!");
                }
                db.SaveChanges();
            }
                return View();
        }

        

        // GET: NewAccount/Edit/5
        [HttpGet]
        public ActionResult Login(LoginViewModel model)
        {
            using (new_testEntities db = new new_testEntities())
            {
                foreach (user user in db.user)
                {
                    if (user.Email == model.Email)
                    {
                        if (Decrypt(user.password, user.code) == model.Password)
                        {
                            //correct login

                        }
                    }
                }
            }
            return View();
        }

        // POST: NewAccount/Edit/5
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

        // GET: NewAccount/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NewAccount/Delete/5
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
