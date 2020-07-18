using Selcuk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Selcuk.Controllers
{
    public class AuthorAdminController : Controller
    {
       
        public ActionResult Index()
        {
          NarailDBEntities db = new NarailDBEntities();
            return View(db.Author.ToList());
        }
    }
}