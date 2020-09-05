using GerenciamentoProduto.Domain.Entidades;

namespace  GerenciamentoProdutos.UI.ViewModels.ProdutoViewModel
{
    public static class ExtensionsAddEditProduto
    {
        public static ProdutoAddEditVM  ToProdutoAddEditVM(this Produto produto)
        {
            return new ProdutoAddEditVM()
            {
                Id = produto.Id,
                descricao = produto.descricao,
                preco = produto.preco,
                TipoProdutoId = produto.TipoProdutoId,
                quantidade = produto.quantidade,
                dtCadastro = produto.dtCadastro
            };
        }


        public static Produto ToProduto(this ProdutoAddEditVM produtoAddEditVM)
        {
            return new Produto()
            {
                Id = produtoAddEditVM.Id,
                descricao = produtoAddEditVM.descricao,
                preco = produtoAddEditVM.preco,
                TipoProdutoId = produtoAddEditVM.TipoProdutoId,
                quantidade = produtoAddEditVM.quantidade,
                dtCadastro = produtoAddEditVM.dtCadastro
            };
        }
    }
}
