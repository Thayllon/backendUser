using Backend.Domain.Models;
using System;

namespace Backend.Applications.DTO
{
    public class UsuariosDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Escolaridade { get; set; }

        public static UsuariosDTO UsuarioDTO(Usuarios usuarios)
        {
            if (usuarios == null)
                return null;

            var usuariosDTO = new UsuariosDTO
            {
                Id = usuarios.Id,
                Nome = usuarios.Nome,
                Sobrenome = usuarios.Sobrenome,
                Email = usuarios.Email,
                DataNascimento = usuarios.DataNascimento,
                Escolaridade = usuarios.Escolaridade,
            };

            return usuariosDTO;
        }
    }
}
