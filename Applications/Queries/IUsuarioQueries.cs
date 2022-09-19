using Backend.Applications.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Applications.Queries
{
    public interface IUsuarioQueries
    {
        Task<IEnumerable<UsuariosDTO>> Get();

        Task<UsuariosDTO> Get(int id);
    }
}
