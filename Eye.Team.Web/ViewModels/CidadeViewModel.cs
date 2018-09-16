using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eye.Team.Web.ViewModels
{
    public class CidadeViewModel
    {
        [Required(ErrorMessage = "O id do Cidade é obrigatório")]
        public int IdCidade { get; set; }

        [Display(Name = "Nome da Cidade")]
        [Required(ErrorMessage = "O nome da Cidade é obrigatório")]
        [MaxLength(100, ErrorMessage = "O nome da Cidade deve conter no máximo 100 caracteres")]        
        public string Nome { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Selecione o Estado")]
        public int NomeEstado { get; set; }
    }
}