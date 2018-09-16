using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eye.Team.Dominio
{
    public class Jogador
    {
        public int IdJogador { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual Time Time { get; set; }
        public int IdTime { get; set; }
    }
}
