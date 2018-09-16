using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eye.Team.Web.ViewModels
{
    public class CidadeExibicaoViewModel
    {
        public int IdCidade { get; set; }

        [Display(Name = "Nome da Cidade")]
        public string Nome { get; set; }

        [Display(Name = "Estado")]
        public int NomeEstado { get; set; }
    }
}