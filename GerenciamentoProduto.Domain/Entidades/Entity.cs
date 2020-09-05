using System;

namespace GerenciamentoProduto.Domain.Entidades
{
    public class Entity
    {
        public Entity()
        {
           dtCadastro = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime dtCadastro { get; set; }
    }
}
