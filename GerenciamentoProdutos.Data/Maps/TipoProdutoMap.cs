using GerenciamentoProduto.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoProdutos.Data.Maps
{
    public class TipoProdutoMap : EntityTypeConfiguration<TipoProduto>
    {

        public TipoProdutoMap()
        {
            ToTable(nameof(TipoProduto));
            HasKey(pk => new { pk.Id });
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.ds_tipoproduto).HasColumnType("varchar").HasMaxLength(200).IsRequired();
            Property(c => c.dtCadastro);
        }
    }
}
