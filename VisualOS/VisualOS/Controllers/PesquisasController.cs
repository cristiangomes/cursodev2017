using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VisualOS.DAL;

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

        public ActionResult PesquisarUsuario()
        {
            var usuarios = from u in bdusuario 
                           select u;
            return View("PesquisarUsuario");
        }




    }
}