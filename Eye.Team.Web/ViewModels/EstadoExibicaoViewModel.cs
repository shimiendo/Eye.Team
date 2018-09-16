using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eye.Team.Web.ViewModels
{
    public class EstadoExibicaoViewModel
    {
        public int IdEstado { get; set; }

        [Display(Name = "Nome do Estado")]
        public string Nome { get; set; }

        [Display(Name = "UF")]
        public string Uf { get; set; }        
    }
}