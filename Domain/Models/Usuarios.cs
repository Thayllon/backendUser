using System;

namespace Backend.Domain.Models
{
    public class Usuarios
    {
        public Usuarios(string nome, string sobrenome, string email, DateTime dataNascimento, string escolaridade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            DataNascimento = dataNascimento;
            Escolaridade = escolaridade;
        }

        public Usuarios(int id, string nome, string sobrenome, string email, DateTime dataNascimento, string escolaridade)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            DataNascimento = dataNascimento;
            Escolaridade = escolaridade;
        }

        public int Id { get; set; }

        //[Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        //[Required(ErrorMessage = "Campo obrigatório")]
        public string Sobrenome { get; set; }

        //[EmailAddress(ErrorMessage = "Endereço de email inválido")]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Campo obrigatório")]
        public DateTime DataNascimento { get; set; }

        //[Required(ErrorMessage = "Campo obrigatório")]
        public string Escolaridade { get; set; }
    }
}
