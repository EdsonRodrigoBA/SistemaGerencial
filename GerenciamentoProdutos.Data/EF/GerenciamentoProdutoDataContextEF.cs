using GerenciamentoProduto.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoProdutos.Data.EF
{
    public class GerenciamentoProdutoDataContextEF : DbContext
    {

        public GerenciamentoProdutoDataContextEF() : base("gerenciaProduto")
        {
            Database.SetInitializer(new DbInitializer());
        }
        //public GerenciamentoProdutoDataContextEF() : base(DadosConexao.StringDeConexao)
        //{
        //    Database.SetInitializer(new DbInitializer());
        //}

        public DbSet<Produto> produtosDBSet { get; set; }
        public DbSet<TipoProduto> TipoprodutosDBSet { get; set; }

        public DbSet<Usuarios> UsuariosDBSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Maps.ProdutosMap());
            modelBuilder.Configurations.Add(new Maps.TipoProdutoMap());
            modelBuilder.Configurations.Add(new Maps.UsuarioMap());
        }
    }
}
