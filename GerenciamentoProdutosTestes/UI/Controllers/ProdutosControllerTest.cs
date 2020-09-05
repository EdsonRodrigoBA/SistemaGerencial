using GerenciamentoProduto.Domain.Contracts.Repositories;
using GerenciamentoProduto.Domain.Entidades;
using GerenciamentoProdutos.UI.Controllers;
using GerenciamentoProdutos.UI.ViewModels.ProdutoViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GerenciamentoProdutosTestes.UI.Controllers
{
    [TestClass]
    class ProdutosControllerTest
    {

        //no meu Controlador Produto 

            [TestMethod, TestCategory("Controllers/ProdutoController")]
        public void O_Metodo_Index_Deve_Retornar_Uma_Lista_De_Produtos()
        {
            
            var produtosController = new ProdutosController(new ProdutoRespositoryFake(), new tipoProdutoRepositoryFake());

            var result = produtosController.Index();
            var model = result.Model as IEnumerable<ProdutoIndexVM>;
            
            Assert.AreEqual(typeof(ViewResult), result.GetType());
            Assert.AreEqual(1, model.Count());
            Assert.IsNotNull(model);

        }
    }

    public class tipoProdutoRepositoryFake : ITipoProdutoRepository
    {
        public void Add(TipoProduto entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(TipoProduto entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public void Edit(TipoProduto entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TipoProduto> Get()
        {
            throw new System.NotImplementedException();
        }

        public TipoProduto Get(int Id)
        {
            throw new System.NotImplementedException();
        }
    }

    public class ProdutoRespositoryFake : IProdutoRepository
    {
        public void Add(Produto entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Produto entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public void Edit(Produto entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Produto> Get()
        {

            var tipo1 = new TipoProduto()
            {
                Id = 1, ds_tipoproduto = "teste típo"
        };
            return new List<Produto>()
            {
                new Produto()
                {
                    Id = 1,
                    descricao = "teste",
                    quantidade = 1,
                    preco = 10,

                    tipoProduto = tipo1,
                    TipoProdutoId = tipo1.Id

                }
            };
        }

        public Produto Get(int Id)
        {
            return new Produto();
        }

        public IEnumerable<Produto> GetByNameContains(string content)
        {
            throw new System.NotImplementedException();
        }
    }
}
