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
        private Model1Container db = new Model1Container();

        public ActionResult PesquisarOS()
        {
            var ListaOS = from o in db.tb_ordemservico select o;
            ListaOS = ListaOS.Where(os => os.Data_abertura != null);
            return View(ListaOS);
        }

        public ActionResult PesquisarUsuario()
        {
            var usuarios = from u in bdusuario 
                           select u;
            return View("PesquisarUsuario");
        }




    }
}