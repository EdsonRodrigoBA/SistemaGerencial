using GerenciamentoProduto.Domain.Contracts.Repositories;
using GerenciamentoProduto.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GerenciamentoProdutos.Data.EF.Repositories
{
    public class RepositoryEF<T> :  IRepository<T> where T : Entity
    {

        protected readonly GerenciamentoProdutoDataContextEF _gerenciamentoProdutoDataContext;
      
        public RepositoryEF(GerenciamentoProdutoDataContextEF gerenciamentoProdutoDataContext)
        {
            _gerenciamentoProdutoDataContext = gerenciamentoProdutoDataContext;
        }
        public IEnumerable<T> Get()
        {
            return _gerenciamentoProdutoDataContext.Set<T>().ToList();
        }

        public T Get(int Id)
        {
            return _gerenciamentoProdutoDataContext.Set<T>().Find(Id);
        }

        public void Add(T entity)
        {
            _gerenciamentoProdutoDataContext.Set<T>().Add(entity);
            Save();
        }

        public void Edit(T entity)
        {
            _gerenciamentoProdutoDataContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            Save();
        }

        public void Delete(T entity)
        {
            _gerenciamentoProdutoDataContext.Set<T>().Remove(entity);
            Save();
        }

        private void Save()
        {
            _gerenciamentoProdutoDataContext.SaveChanges();
        }

        public void Dispose()
        {
            //_gerenciamentoProdutoDataContext.Dispose();
        }
    }
}
