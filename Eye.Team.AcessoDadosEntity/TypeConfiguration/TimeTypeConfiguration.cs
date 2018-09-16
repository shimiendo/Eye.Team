using Eye.Team.Comum.Entity;
using Eye.Team.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eye.Team.AcessoDadosEntity.TypeConfiguration
{
    class TimeTypeConfiguration : EyeEntityAbstractConfig<Time>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.IdTime)
                .HasColumnName("TIM_ID")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(p => p.Nome)
                .HasColumnName("TIM_NOME")
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.IdCidade)
                .HasColumnName("CID_ID")
                .IsRequired();
        }

        protected override void ConfigurarChaveEstrangeira()
        {
            HasRequired(p => p.Cidade)
                .WithRequiredPrincipal();
                
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(p => p.IdTime);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("TIMES");
        }
    }
}
