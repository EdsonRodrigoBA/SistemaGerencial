using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoProduto.Domain.Entidades
{
    public class TipoProduto : Entity
    {
        public String ds_tipoproduto { get; set; }
        public virtual ICollection<Produto> produtos { get; set; }
    }
}
