using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneBook.Controllers
{
    public class HomeController : Controller
    {
        static List<Data> PhoneBook = new List<Data>();
        // GET: Home
        public ActionResult GoToHome()
        {
            return View("FirstPage");
        }
        public ActionResult Enter()
        {
            return View("NewUser");
        }
        public ActionResult Save(Data obj)     
        {
            PhoneBook.Add(obj);
            return View(PhoneBook);
        }
        
    }
}