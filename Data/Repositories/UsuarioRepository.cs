using Backend.Data.Context;
using Backend.Domain.Interfaces;
using Backend.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public readonly AppDbContext _context;

        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Usuarios>> Get()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task<Usuarios> Get(int id)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<Usuarios> Create(Usuarios usuario)
        {
            if (usuario.DataNascimento.Date < System.DateTime.Now.Date)
            {
                if (usuario.Escolaridade.Trim() == "Infantil" || usuario.Escolaridade.Trim() == "Fundamental" || usuario.Escolaridade.Trim() == "Médio" || usuario.Escolaridade.Trim() == "Superior")
                {
                    _context.Usuarios.Add(usuario);

                    await _context.SaveChangesAsync();

                    return usuario;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public async Task<Usuarios> Update(Usuarios usuario)
        {
            if (usuario.DataNascimento.Date < System.DateTime.Now.Date)
            {
                if (usuario.Escolaridade.Trim() == "Infantil" || usuario.Escolaridade.Trim() == "Fundamental" || usuario.Escolaridade.Trim() == "Médio" || usuario.Escolaridade.Trim() == "Superior")
                {
                    _context.Entry(usuario).State = EntityState.Modified;

                    await _context.SaveChangesAsync();

                    return usuario;
                }
                else
                {
                    return null;
                }
        }
            else
            {
                return null;
            }
        }

        public async Task Delete(int id)
        {
            var data = await _context.Usuarios.FindAsync(id);

            _context.Usuarios.Remove(data);

            await _context.SaveChangesAsync();
        }
    }
}
