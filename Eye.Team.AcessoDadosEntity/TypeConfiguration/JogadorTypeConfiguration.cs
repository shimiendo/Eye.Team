using Eye.Team.Comum.Entity;
using Eye.Team.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eye.Team.AcessoDadosEntity.TypeConfiguration
{
    class JogadorTypeConfiguration : EyeEntityAbstractConfig<Jogador>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.IdJogador)
                .HasColumnName("JOG_ID")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(p => p.Nome)
                .HasColumnName("JOG_NOME")
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.Idade)
                .HasColumnName("JOG_IDADE")
                .IsRequired();
        }

        protected override void ConfigurarChaveEstrangeira()
        {
            HasRequired(p => p.Time)
                .WithRequiredPrincipal();
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(p => p.IdJogador);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("JOGADORES");
        }
    }
}
