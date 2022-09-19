using Backend.Applications.DTO;
using Backend.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;


namespace Backend.Applications.Queries
{
    public class UsuarioQueries : IUsuarioQueries
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioQueries(IUsuarioRepository usuarioRepository)
        {
            this._usuarioRepository = usuarioRepository;
        }

        public async Task<IEnumerable<UsuariosDTO>> Get()
        {
            var usuario = await _usuarioRepository.Get();

            return usuario.Select(u => UsuariosDTO.UsuarioDTO(u));
        }

        public async Task<UsuariosDTO> Get(int id)
        {
            var usuario = await _usuarioRepository.Get(id);

            return UsuariosDTO.UsuarioDTO(usuario);
        }
    }
}
