using GerenciamentoProduto.Domain.Contracts.Repositories;
using GerenciamentoProduto.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoProdutos.Data.EF.Repositories
{
   public class UsuarioRepositoryEF : RepositoryEF<Usuarios>, IUsuarioRepository
    {
        public UsuarioRepositoryEF(GerenciamentoProdutoDataContextEF gerenciamentoProdutoDataContext) : base(gerenciamentoProdutoDataContext)
        {
        }

        public Usuarios GetUser(string email)
        {
            return _gerenciamentoProdutoDataContext.UsuariosDBSet.FirstOrDefault(u => u.email.ToLower() == email.ToLower());
        }
    }
}
