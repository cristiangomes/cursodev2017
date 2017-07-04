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

        public ActionResult PesquisarServico()
        {
            Random random = new Random();
            return View(CriaServicosMock(random.Next(123123)));
        }

        private List<tb_servico> CriaServicosMock(int qtdItens)
        {
            Random random = new Random();
            List<tb_servico> listaServicos = new List<tb_servico>();
            for (int i = 0; i < qtdItens; i++)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                tb_servico servico = new tb_servico();
                listaServicos.Add(servico);
                servico.Nome = random.Next().ToString();
                servico.Descricao = random.Next().ToString();
            }
            return listaServicos;
        }
    }
}