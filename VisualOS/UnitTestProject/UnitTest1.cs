using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VisualOS.DAL;
using System.Web;
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

        public void TestMockOS()
        {

        }
    }
}
