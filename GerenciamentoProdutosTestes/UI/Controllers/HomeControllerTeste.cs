using GerenciamentoProdutos.UI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace GerenciamentoProdutosTestes.UI.Controllers
{
    [TestClass]
    public class HomeControllerTeste
    {
        //No meu Controlador Home
        [TestMethod, TestCategory("Controllers/HomeController")]
        public void O_Metodo_Index_Deve_Retornar_Uma_View()
        {
            //arrange

            var homeController = new HomeController();

            //action - acoes
            var result = homeController.Sobre();

            //acets - resultado esperado

            Assert.AreEqual(typeof(ViewResult), result.GetType());
        }
    }
}
