using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eye.Team.Web.ViewModels
{
    public class EstadoViewModel
    {
        [Required(ErrorMessage = "O id do Estado é obrigatório")]
        public int IdEstado { get; set; }

        [Display(Name = "Nome do Estado")]
        [Required(ErrorMessage = "O nome do Estado é obrigatório")]
        [MaxLength(100, ErrorMessage = "O nome do Estado deve conter no máximo 100 caracteres")]
        public string Nome { get; set; }
        
        [Display(Name = "UF")]
        [Required(ErrorMessage = "O UF é obrigatório")]
        [MaxLength(100, ErrorMessage = "O nome do UF deve conter no máximo 2 caracteres")]
        public string Uf { get; set; }
    }
}