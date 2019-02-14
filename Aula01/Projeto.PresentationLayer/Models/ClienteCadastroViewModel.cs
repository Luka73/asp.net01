using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.PresentationLayer.Models
{
    public class ClienteCadastroViewModel
    {
        [MinLength(3, ErrorMessage ="Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(50, ErrorMessage ="Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage ="Por favor, informe o nome do cliente.")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage ="Por favor, informe um email válido.")]
        [Required(ErrorMessage ="Por favor, informe o email do cliente.")]
        public string  Email { get; set; }
    }
}