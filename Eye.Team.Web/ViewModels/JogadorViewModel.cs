using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eye.Team.Web.ViewModels
{
    public class JogadorViewModel
    {
        [Required(ErrorMessage = "O id do Jogador é obrigatório")]
        public int IdJogador { get; set; }


        [Display(Name = "Nome do Jogador")]
        [Required(ErrorMessage = "O nome da Time é obrigatório")]
        [MaxLength(100, ErrorMessage = "O nome da Time deve conter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Idade")]        
        [Required(ErrorMessage = "O nome da Idade é obrigatório")]
        public int Idade { get; set; }

        [Display(Name = "Time")]
        [Required(ErrorMessage = "Selecione o Time")]  
        public int IdTime { get; set; }
    }
}