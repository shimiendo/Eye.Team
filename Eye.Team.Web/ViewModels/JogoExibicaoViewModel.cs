using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eye.Team.Web.ViewModels
{
    public class JogoExibicaoViewModel
    {
        public int IdJogo { get; set; }

        [Display(Name = "Data do Jogo")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataJogo { get; set; }

        [Display(Name = "Quantidade de Gol do Time 1")]
        public int QtdeGolTime1 { get; set; }

        [Display(Name = "Quantidade de Gol do Time 2")]
        public int QtdeGolTime2 { get; set; }

        [Display(Name = "Time 1")]
        public int IdTime1 { get; set; }

        [Display(Name = "Time 2")]
        public int IdTime2 { get; set; }
    }
}