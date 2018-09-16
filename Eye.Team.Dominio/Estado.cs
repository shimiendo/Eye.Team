using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eye.Team.Dominio
{
    public class Estado
    {
        public int IdEstado { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }    
        
        public virtual ICollection<Cidade> Cidades { get; set; }

    }
}
