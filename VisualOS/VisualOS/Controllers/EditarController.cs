using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VisualOS.DAL;

namespace VisualOS.Controllers
{
    public class EditarController : ControllerBase
    {
        // GET: Editar
        public ActionResult EditarOS()
        {
            return View(CriaListaOSMock(1)[0]);
        }
        //public ActionResult EditarServico()
        //{
        //    Random random = new Random();
        //    return View(CriaServicosMock(random.Next(4)));
        //}

        public ActionResult EditarUsuario()
        {
            return View(CriaListaUsuariosMOCK(1)[0]);
        }
    }
}
