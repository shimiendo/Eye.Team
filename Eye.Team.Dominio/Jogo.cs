using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eye.Team.Dominio
{
    public class Jogo
    {
        public int IdJogo { get; set; }
        public DateTime DataJogo { get; set; }
        public int QtdeGolTime1 { get; set; }
        public int QtdeGolTime2 { get; set; }

        public virtual Time Time { get; set; }
        public int IdTime1 { get; set; }
        public int IdTime2 { get; set; }
    }
}
