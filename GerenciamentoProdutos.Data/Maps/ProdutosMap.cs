using GerenciamentoProduto.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoProdutos.Data.Maps
{
    public class ProdutosMap : EntityTypeConfiguration<Produto>
    {
        public ProdutosMap()
        {
            ToTable(nameof(Produto));
            HasKey(pk => new { pk.Id });
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.descricao).HasColumnType("varchar").HasMaxLength(500).IsRequired();
            Property(c => c.preco).HasColumnType("money");
            Property(c => c.quantidade);
            Property(c => c.dtCadastro);

            //relacionamento
            HasRequired(prod => prod.tipoProduto).WithMany(tipo => tipo.produtos).HasForeignKey(fk => fk.TipoProdutoId);
        }
    }
}
