using GerenciamentoProduto.Domain.Contracts.Repositories;
using GerenciamentoProduto.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoProdutos.Data.EF.Repositories
{
    public class TipoProdutoRepositoryEF : RepositoryEF<TipoProduto>, ITipoProdutoRepository

    {
        public TipoProdutoRepositoryEF(GerenciamentoProdutoDataContextEF gerenciamentoProdutoDataContext) : base(gerenciamentoProdutoDataContext)
        {
        }
    }
}
