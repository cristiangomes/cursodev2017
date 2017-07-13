using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisualOS.Controllers;
using System.Collections.Generic;
using VisualOS.DAL;
using System.Web.Mvc;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMockServico()
        {
            VisualOS.Controllers.ControllerBase controler = new VisualOS.Controllers.ControllerBase();
            List<tb_servico> listaServicos = new List<tb_servico>();
            listaServicos = controler.CriaServicosMock(4);

            Assert.AreEqual(3, listaServicos.Count);
        }

        [TestMethod]
        public void TestMockOS()
        {
            List<tb_ordemservico> OS = new List<tb_ordemservico>();
            VisualOS.Controllers.ControllerBase controller = new VisualOS.Controllers.ControllerBase();
            OS = controller.CriaListaOSMock(3);
        }

        [TestMethod]
        public void TesteMockCargo()
        {
            List<tb_cargo> Cargos = new List<tb_cargo>();
            VisualOS.Controllers.ControllerBase controller = new VisualOS.Controllers.ControllerBase();
            Cargos = controller.CriarCargosMock(2);

            Assert.AreNotEqual(Cargos[1].ID, 22);
            Assert.AreEqual(Cargos.Count, 2);
        }

        [TestMethod]
        public void TestMockUsuario()
        {
            List<tb_usuario> Usuario = new List<tb_usuario>();
            VisualOS.Controllers.ControllerBase controller = new VisualOS.Controllers.ControllerBase();
            Usuario = controller.CriaListaUsuariosMOCK(5);

            Assert.AreEqual(Usuario[1].ID, 34);
        }
    }
}
   
