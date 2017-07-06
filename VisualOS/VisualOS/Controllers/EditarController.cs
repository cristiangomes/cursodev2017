using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VisualOS.DAL;

namespace VisualOS.Controllers
{
    public class EditarController : Controller
    {
        // GET: Editar
        public ActionResult EditarOS()
        {

            return View();
        }
        //public ActionResult EditarServico()
        //{
        //    Random random = new Random();
        //    return View(CriaServicosMock(random.Next(4)));
        //}
    }
}



