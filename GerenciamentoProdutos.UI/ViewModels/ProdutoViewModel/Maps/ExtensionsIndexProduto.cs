using System.Collections.Generic;
using System.Linq;
using GerenciamentoProduto.Domain.Entidades;
namespace  GerenciamentoProdutos.UI.ViewModels.ProdutoViewModel
{
    public static class ExtensionsIndexProduto
    {
        public static IEnumerable<ProdutoIndexVM> ToProdutoIndexVMs(this IEnumerable<Produto> produtos)
        {

            return produtos.Select(p =>
           new ProdutoIndexVM()
           {

               Id = p.Id,
               descricao = p.descricao,
               preco = p.preco,
               tipoproduto = p.tipoProduto.ds_tipoproduto,
               quantidade = p.quantidade,
               dtCadastro = p.dtCadastro

           });
        }
    }
}
