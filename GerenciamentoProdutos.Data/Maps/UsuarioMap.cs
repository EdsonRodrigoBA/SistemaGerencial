using GerenciamentoProduto.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoProdutos.Data.Maps
{
    class UsuarioMap : EntityTypeConfiguration<Usuarios>
    {
        public UsuarioMap()
        {
            ToTable(nameof(Usuarios));
            HasKey(pk => new { pk.Id });
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.usuario).HasColumnType("varchar").HasMaxLength(80).IsRequired();
            Property(c => c.senha).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            Property(c => c.email).HasColumnType("varchar").HasMaxLength(100).IsRequired()
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,new IndexAnnotation(new IndexAttribute("UQ_EMAIL.Usuarios.email") { IsUnique = true}));
            Property(c => c.dtCadastro);
        }
    }
}
