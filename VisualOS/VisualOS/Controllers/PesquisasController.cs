using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VisualOS.DAL;

namespace VisualOS.Controllers
{
    public class PesquisasController : ControllerBase
    {

        // GET: Pesquisas

        public ActionResult PesquisarUsuario()
        {
            return View("PesquisarUsuario", CriaListaUsuariosMOCK(10));
        }
       
        public ActionResult PesquisarOS()
        {
            List<tb_ordemservico> ListaOS = new List<tb_ordemservico>();
            Random random = new Random();
            return View(CriaListaOSMock(random.Next(1, 20)));
        }

        public ActionResult PesquisarServico()
        {
            Random random = new Random();
            return View(CriaServicosMock(random.Next(20)));   
        }

        public ActionResult PesquisarCargo()
        {
            Random random = new Random();
            return View(CriarCargosMock(random.Next(5, 10)));
           
        }

        public ActionResult DeletarOS()
        {
            return RedirectToAction("PesquisarOS");
        }
    }

}

