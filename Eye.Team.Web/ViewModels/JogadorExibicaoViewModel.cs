using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eye.Team.Web.ViewModels
{
    public class JogadorExibicaoViewModel
    {
        public int IdJogador { get; set; }

        [Display(Name = "Nome do Jogador")]
        public string Nome { get; set; }

        [Display(Name = "Idade")]
        public int Idade { get; set; }

        [Display(Name = "Time")]
        public int IdTime { get; set; }
    }
}