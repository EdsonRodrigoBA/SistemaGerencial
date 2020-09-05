using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoProduto.Domain.Entidades
{
    public class Produto : Entity
    {
    
        public String descricao { get; set; }
        public decimal preco { get; set; }

        public int quantidade { get; set; }
        // public String tipo { get; set; }



        public int TipoProdutoId { get; set; }

     
        public virtual TipoProduto tipoProduto { get; set; }
    }
}
