using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VisualOS.DAL;

namespace VisualOS.Controllers
{
    public class ControllerBase : Controller
    {
        public List<tb_ordemservico> CriaListaOSMock(int qtdItens)
        {
            List<tb_ordemservico> ListaOS = new List<tb_ordemservico>();
            Random random = new Random();

            for (int i = 0; i < qtdItens; i++)
            {
                tb_usuario usuario = new tb_usuario();
                tb_ordemservico OS = new tb_ordemservico();

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
                OS.Data_conclusao = DateTime.Now.AddDays(2);

                ListaOS.Add(OS);
            }
            return ListaOS;
        }
        public List<tb_servico> CriaServicosMock(int qtdItens)
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