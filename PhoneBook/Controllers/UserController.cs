using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneBook.Models;

namespace PhoneBook.Controllers
{
    public class UserController : Controller
    {
        // GET: User
       
        public ActionResult Save()
        {
            Data obj = new Data();
            obj.Name = Request.Form["Name"];
            obj.Address1 = Request.Form["Address1"];
            obj.Address2 = Request.Form["Address2"];
            obj.City = Request.Form["City"];
            obj.Pincode = Request.Form["Pincode"];
            obj.Phonenumber = Request.Form["Phonenumber"];
            return View("Save", obj);
        }
    }
}