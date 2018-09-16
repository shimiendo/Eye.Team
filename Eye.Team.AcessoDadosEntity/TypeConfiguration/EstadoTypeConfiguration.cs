using Eye.Team.Comum.Entity;
using Eye.Team.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace Eye.Team.AcessoDadosEntity.TypeConfiguration
{
    class EstadoTypeConfiguration : EyeEntityAbstractConfig<Estado>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.IdEstado)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("EST_ID");

            Property(p => p.Nome)
                .IsRequired()
                .HasColumnName("EST_NOME")
                .HasMaxLength(100);

            Property(p => p.Uf)
                .IsRequired()
                .HasColumnName("EST_UF")
                .HasMaxLength(2);
        }

        protected override void ConfigurarChaveEstrangeira()
        {
            
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(P => P.IdEstado);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("ESTADOS");
        }
    }
}
