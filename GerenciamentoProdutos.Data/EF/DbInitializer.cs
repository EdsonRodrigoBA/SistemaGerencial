using GerenciamentoProduto.Domain.Entidades;
using GerenciamentoProduto.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoProdutos.Data.EF
{
    internal class DbInitializer : CreateDatabaseIfNotExists<GerenciamentoProdutoDataContextEF>
    {
        protected override void Seed(GerenciamentoProdutoDataContextEF context)

        {
            var alimentos = new TipoProduto() { ds_tipoproduto = "Refrigerantes" };
            var higiene = new TipoProduto() { ds_tipoproduto = "Higiene" };
            var eletronicos = new TipoProduto() { ds_tipoproduto = "Eletronicos" };

            var produtos = new List<Produto>()
            {
                new Produto(){

                    descricao = "Coca Cola",
                    tipoProduto = alimentos,
                    preco = 10,
                    quantidade = 20,

                },

                      new Produto(){

                    descricao = "Desinfetante Hipe",
                   tipoProduto = higiene,
                    preco = 10,
                    quantidade = 5,

                },

                             new Produto(){

                    descricao = "Feijao Padin 500g ",
                    tipoProduto = alimentos,
                    preco = 10,
                    quantidade = 5,

                },

                         new Produto(){

                    descricao = "Cafe Pilao  ",
                  tipoProduto = alimentos,
                    preco = 10,
                    quantidade = 5,

                },
                                       new Produto(){

                    descricao = "Celular Moto z 2  ",
                  tipoProduto = eletronicos,
                    preco = 10,
                    quantidade = 5,

                },

                     new Produto(){

                    descricao = "Agua Sanitaria  ",
                  tipoProduto = higiene,
                    preco = 10,
                    quantidade = 5,

                },

            };

            context.produtosDBSet.AddRange(produtos);

            context.UsuariosDBSet.AddRange(
                new List<Usuarios>() {
                new Usuarios()
            {
                usuario = "EdsonRodrigoBA",
                email = "edsonrodrigoanalista@gmail.com",
                senha = "123456".Encrypt()

            },
                      new Usuarios()
            {
                usuario = "usertesteBA",
                email = "testecadastro@gmail.com",
                senha = "12356465".Encrypt()

            }
                });
            context.SaveChanges();
        }
    }
}
