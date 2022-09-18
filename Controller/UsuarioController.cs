using AutoMapper;
using Backend.Applications.DTO;
using Backend.Domain.Interfaces;
using Backend.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioController(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        [HttpGet]

        public async Task<IEnumerable<Usuarios>> GetUser()
        {
            return await _usuarioRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuarios>> GetOneUser(int id)
        {
            var usuario = await _usuarioRepository.Get(id);

            if (usuario != null)
            {
                return usuario;
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<ActionResult<Usuarios>> PostUser([FromBody] UsuariosDTO usuarioDTO)
        {
            var usuario = _mapper.Map<Usuarios>(usuarioDTO);

            if (usuario != null)
            {
                if (usuario.DataNascimento.Date < System.DateTime.Now.Date)
                {
                    await _usuarioRepository.Create(usuario);

                    return CreatedAtAction(nameof(GetUser), new { id = usuario.Id }, usuario);
                }
                else
                {
                    return BadRequest();
                }
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public async Task<ActionResult<Usuarios>> PutUser([FromBody] UsuariosUpdateDTO usuarioDTO)
        {
            var usuario = _mapper.Map<Usuarios>(usuarioDTO);

            if (usuario != null)
            {
                if (usuario.DataNascimento.Date < System.DateTime.Now.Date)
                {
                    await _usuarioRepository.Update(usuario);

                    return usuario;
                }
                else
                {
                    return BadRequest();
                }
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            var data = await _usuarioRepository.Get(id);

            if (data == null)
            {
                return NotFound();
            }
            else
            {
                await _usuarioRepository.Delete(data.Id);
                return NoContent();
            }
        }
    }
}
