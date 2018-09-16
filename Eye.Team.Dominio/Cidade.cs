using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eye.Team.Dominio
{
    public class Cidade
    {
        public int IdCidade { get; set; }
        public string Nome { get; set; }

        public virtual Estado Estado { get; set; }
        public int IdEstado { get; set; }
    }
}
