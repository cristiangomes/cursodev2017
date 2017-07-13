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

            Assert.AreNotEqual(OS[0].ID, 22);
            Assert.AreEqual(OS.Count, 3);
        }

        public void TesteMockCargo()
        {
        }

        public void TestMockUsuario()
        {
            
        }
    }
}
            