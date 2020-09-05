using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoProduto.Domain.Entidades
{
    public class Usuarios : Entity
    {
      
        public String usuario { get; set; }

      
        public String email { get; set; }

      
        public String senha { get; set; }
    }
}
