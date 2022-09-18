using System;
using System.ComponentModel.DataAnnotations;

namespace Backend.Applications.DTO
{
    public class UsuariosDTO
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Sobrenome { get; set; }

        [EmailAddress(ErrorMessage = "Endereço de email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Escolaridade { get; set; }
    }
}
