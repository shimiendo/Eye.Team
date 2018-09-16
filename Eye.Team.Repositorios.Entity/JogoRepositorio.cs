using Eye.Team.AcessoDadosEntity.Contexto;
using Eye.Team.Dominio;
using Eye.Team.Repositorio.EntityFr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eye.Team.Repositorios.Entity
{
    public class JogoRepositorio : RepositorioGenericoEntity<Jogo, int>
    {
        public JogoRepositorio(EyeTeamDbContext contexto)
            : base(contexto)
        {

        }
    }
}
