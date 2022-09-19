using Backend.Applications.Commands;
using Backend.Domain.Interfaces;
using Backend.Domain.Models;
using System.Threading.Tasks;

namespace Backend.Applications.CommandHandlers
{

    public class UsuarioCommandHandler
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IUnitOfWork _context;

        public UsuarioCommandHandler(IUsuarioRepository usuarioRepository, IUnitOfWork context)
        {
            _usuarioRepository = usuarioRepository;
            _context = context;
        }

        //public async Task Handle(AdicionarUsuarioCommand request)
        //{
        //    if (request != null)
        //    {
        //        Usuarios usuario = new Usuarios(request.Nome, request.Sobrenome, request.Email,  request.DataNascimento, request.Escolaridade);      

        //        return await _usuarioRepository.Create(usuario);
        //    }
        //}

        //public async Task Handle(AtualizarUsuarioCommand request)
        //{
        //    var usuario = await _usuarioRepository.Get(request.Id);

        //    if (usuario != null)
        //    {
        //        usuario.Nome = request.Nome;
        //        usuario.Sobrenome = request.Sobrenome;
        //        usuario.Email = request.Email;
        //        usuario.DataNascimento = request.DataNascimento;
        //        usuario.Escolaridade = request.Escolaridade;  

        //        return _usuarioRepository.Update(usuario);
        //    }
        //}

        //public async Task Handle(RemoverUsuarioCommand request)
        //{
        //    if (request != null)
        //    {
        //        return await _usuarioRepository.Delete(request.Id);
        //    }
        //}
    }
}
