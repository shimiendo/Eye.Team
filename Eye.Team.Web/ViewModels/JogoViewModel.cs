using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eye.Team.Web.ViewModels
{
    public class JogoViewModel
    {
        [Required(ErrorMessage = "O id do Jogo é obrigatório")]
        public int IdJogo { get; set; }

        [Display(Name = "Data do Jogo")]
        [Required(ErrorMessage = "A data do Jogo é obrigatório")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataJogo { get; set; }

        [Required(ErrorMessage = "O quantidade de Gol do Time 1 é obrigatório")]        
        public int QtdeGolTime1 { get; set; }

        [Required(ErrorMessage = "O quantidade de Gol do Time 2 é obrigatório")]
        public int QtdeGolTime2 { get; set; }

        [Required(ErrorMessage = "Selecione o Time 1")]
        [Display(Name = "Time 1")]
        public int IdTime1 { get; set; }

        [Required(ErrorMessage = "Selecione o Time 2")]
        [Display(Name = "Time 2")]
        public int IdTime2 { get; set; }
    }
}