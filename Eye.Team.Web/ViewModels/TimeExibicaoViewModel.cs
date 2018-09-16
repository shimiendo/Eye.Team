using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eye.Team.Web.ViewModels
{
    public class TimeExibicaoViewModel
    {
        public int IdTime { get; set; }

        [Display(Name = "Nome do Time")]
        public string Nome { get; set; }

        [Display(Name = "Cidade")]
        public int NomeCidade { get; set; }
    }
}