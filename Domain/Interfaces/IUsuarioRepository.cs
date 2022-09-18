using Backend.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuarios>> Get();

        Task<Usuarios> Get(int id);

        Task<Usuarios> Create(Usuarios usuario);

        Task<Usuarios> Update(Usuarios usuario);

        Task Delete(int id);
    }
}
