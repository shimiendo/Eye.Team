using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eye.Team.Web.ViewModels
{
    public class TimeViewModel
    {
        [Required(ErrorMessage = "O id do Time é obrigatório")]
        public int IdTime { get; set; }

        [Display(Name = "Nome da Time")]
        [Required(ErrorMessage = "O nome da Time é obrigatório")]
        [MaxLength(100, ErrorMessage = "O nome da Time deve conter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Selecione o Cidade")]
        [Display(Name = "Cidade")]
        public int IdCidade { get; set; }
    }
}