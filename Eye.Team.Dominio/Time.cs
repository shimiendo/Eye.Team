using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eye.Team.Dominio
{
    public class Time
    {
        public int IdTime { get; set; }
        public string Nome { get; set; }

        public virtual Cidade Cidade { get; set;}        
        public int IdCidade { get; set; }
    }
}
