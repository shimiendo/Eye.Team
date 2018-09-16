using Eye.Team.Comum.Entity;
using Eye.Team.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eye.Team.AcessoDadosEntity.TypeConfiguration
{
    class CidadeTypeConfiguration : EyeEntityAbstractConfig<Cidade>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.IdCidade)
                .IsRequired()
                .HasColumnName("CID_ID")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(p => p.Nome)
                .IsRequired()
                .HasColumnName("CID_NOME")
                .HasMaxLength(100);

            Property(p => p.IdEstado)
                .HasColumnName("EST_ID")
                .IsRequired();
        }

        protected override void ConfigurarChaveEstrangeira()
        {
            HasRequired(p => p.Estado)
                .WithMany(p => p.Cidades)
                .HasForeignKey(fk => fk.IdEstado);
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(p => p.IdCidade);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("CIDADES");
        }
    }
}
