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
    }
}