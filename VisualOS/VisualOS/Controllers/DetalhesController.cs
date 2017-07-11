using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VisualOS.Controllers
{
    public class DetalhesController : ControllerBase
    {
        // GET: Detalhes
        public ActionResult DetalheOS()
        {
            return View(CriaListaOSMock(1)[0]);
        }
        public ActionResult DetalhesCargo()
        {
            return View(CriarCargosMock(1)[0]);
        }
        public ActionResult DetalheServico()
        {
            return View(CriaServicosMock(1)[0]);
        }
    }
}