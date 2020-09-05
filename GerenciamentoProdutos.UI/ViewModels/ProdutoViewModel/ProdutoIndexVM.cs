using System;

namespace  GerenciamentoProdutos.UI.ViewModels.ProdutoViewModel
{
    public class ProdutoIndexVM
    {
        public int Id { get; set; }
        public String descricao { get; set; }
        public decimal preco { get; set; }

        public int quantidade { get; set; }
        // public String tipo { get; set; }

        public DateTime dtCadastro { get; set; } = DateTime.Now;

        public String tipoproduto { get; set; }

    }
}