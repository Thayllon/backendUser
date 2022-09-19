using Backend.Data.Context;
using Backend.Domain.Interfaces;
using System.Threading.Tasks;

namespace Backend.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private UsuarioRepository _usuarioRepository;
        public AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public IUsuarioRepository UsuarioRepository
        {
            get
            {
                return _usuarioRepository = _usuarioRepository ?? new UsuarioRepository(_context);
            }
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}
