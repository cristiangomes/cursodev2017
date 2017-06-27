using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VisualOS.Controllers
{
    public class PesquisasController : Controller
    {
        // GET: Pesquisas
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PesquisarOS()
        {
            return View();
        }
    }
}