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
            //var usuarios = from u in db.tb_usuario 
            //               select u;
            return View("PesquisarUsuario",CriaListaUsuariosMOCK(10));
        }

        private List<tb_usuario> CriaListaUsuariosMOCK(int qtdUsuarios)
        {
            List<tb_usuario> listaUsuarios = new List<tb_usuario>();

            for (int i = 0; i < qtdUsuarios; i++)
            {
                tb_usuario usuario = new tb_usuario();
                usuario.CPF = new Random().Next(111111111, 999999999);
                usuario.DataNascimento = DateTime.Now;
                usuario.DDD = new Random().Next(999);
                usuario.Email = new Random().Next(999999999).ToString();
                usuario.ID = new Random().Next(999999999);
                usuario.NomeCompleto = new Random().Next(999999999).ToString();
                usuario.Senha = new Random().Next(65837689).ToString();
                usuario.Telefone = new Random().Next(999999999);
                listaUsuarios.Add(usuario);
            }
            
            return listaUsuarios;

        }



    }
}