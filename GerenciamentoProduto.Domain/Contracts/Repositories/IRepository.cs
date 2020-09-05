using GerenciamentoProduto.Domain.Entidades;
using System;
using System.Collections.Generic;

namespace GerenciamentoProduto.Domain.Contracts.Repositories
{
    public interface IRepository<T> : IDisposable where T : Entity
    {
        IEnumerable<T> Get();
        T Get(int Id);
        void Add(T entity);
        void Edit(T entity);
        void Delete(T entity);


    }
}
