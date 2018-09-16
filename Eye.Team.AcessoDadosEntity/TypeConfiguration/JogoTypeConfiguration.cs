using Eye.Team.Comum.Entity;
using Eye.Team.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eye.Team.AcessoDadosEntity.TypeConfiguration
{
    class JogoTypeConfiguration : EyeEntityAbstractConfig<Jogo>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.IdJogo)
                .HasColumnName("JOG_ID")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(p => p.IdTime1)
                .HasColumnName("ID_TIME1")
                .IsRequired();

            Property(p => p.IdTime2)
                .HasColumnName("ID_TIME2")
                .IsRequired();

            Property(p => p.DataJogo)
                .HasColumnName("JOG_DATAJOGO")
                .IsRequired();

            Property(p => p.QtdeGolTime1)
                .IsOptional()
                .HasColumnName("JOG_QTDEGOLTIME1");

            Property(p => p.QtdeGolTime2)
                .IsOptional()
                .HasColumnName("JOG_QTDEGOLTIME2");
        }

        protected override void ConfigurarChaveEstrangeira()
        {
            HasRequired(p => p.Time)
                .WithRequiredPrincipal();
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(p => p.IdJogo);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("JOGOS");
        }
    }
}
