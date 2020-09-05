using System;
using System.ComponentModel.DataAnnotations;

namespace GerenciamentoProdutos.UI.ViewModels.ProdutoViewModel
{
    public class ProdutoAddEditVM
    {
        public ProdutoAddEditVM()
        {
            dtCadastro = DateTime.Now;
        }
        public int Id { get; set; }
        [Required]
        public String descricao { get; set; }
        public decimal preco { get; set; }

        public int quantidade { get; set; }
        // public String tipo { get; set; }


        [Display(Name = "Tipo de Produto")]
        public int TipoProdutoId { get; set; }



        public DateTime dtCadastro { get; set; } = DateTime.Now;


    }
}