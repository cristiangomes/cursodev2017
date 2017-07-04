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
            //var ListaOS = from o in db.tb_ordemservico select o;
            //ListaOS = ListaOS.Where(os => os.Data_abertura != null);
            List<tb_ordemservico> ListaOS = new List<tb_ordemservico>();
            Random random = new Random();
            ListaOS = CriaListaOSMock(random.Next(1, 20));
            return View(ListaOS);
        }

        private List<tb_ordemservico> CriaListaOSMock(int qtdItens)
        {
            List <tb_ordemservico> ListaOS = new List<tb_ordemservico>();

            for (int i=0; i<qtdItens; i++)
            {
                tb_usuario usuario = new tb_usuario();
                tb_ordemservico OS = new tb_ordemservico();
                Random random = new Random();

                usuario.CPF = random.Next(111111111, 999999999);
                usuario.DataNascimento = DateTime.Now;
                usuario.DDD = random.Next(01, 99);
                usuario.Email = random.Next().ToString();
                usuario.ID = random.Next(01, 1000);
                usuario.NomeCompleto = random.Next().ToString();
                usuario.Senha = random.Next().ToString();
                usuario.Telefone = random.Next(11111111, 999999999);

                OS.ID = random.Next(1, 999999999);
                OS.tb_usuario = usuario;
                OS.ID_Usuario_Responsavel = random.Next(1, 999999999);
                OS.Tipo_OS = random.Next(31231231).ToString();
                OS.Data_abertura = DateTime.Now;

                ListaOS.Add(OS);
            }
            return ListaOS;
        }
    }

}