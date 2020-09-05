using GerenciamentoProduto.Domain.Contracts.Repositories;
using GerenciamentoProduto.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoProdutos.Data.EF.Repositories
{
    public class ProdutoRepositoryEF : RepositoryEF<Produto>, IProdutoRepository
    {
        public ProdutoRepositoryEF(GerenciamentoProdutoDataContextEF gerenciamentoProdutoDataContext) : base(gerenciamentoProdutoDataContext)
        {
        }

        public IEnumerable<Produto> GetByNameContains(string content)
        {
           /*
            * Usando Link
            return from p in _gerenciamentoProdutoDataContext.produtosDBSet.Where(p => p.descricao.Contains(content))

                   select p;*/

            //Usando LambdaExpress
            return _gerenciamentoProdutoDataContext.produtosDBSet.Where(p => p.descricao.Contains(content));

        }
    }
}
