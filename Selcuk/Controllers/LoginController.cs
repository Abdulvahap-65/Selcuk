using Selcuk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Selcuk.Controllers
{
    public class LoginController : Controller
    {
     NarailDBEntities db = new NarailDBEntities(); 
        public ActionResult Index()
        {
            var model = db.Author.ToList();
            return View();
        }
    }
}