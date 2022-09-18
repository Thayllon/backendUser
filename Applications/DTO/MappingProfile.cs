using AutoMapper;
using Backend.Domain.Models;

namespace Backend.Applications.DTO
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Usuarios, UsuariosDTO>().ReverseMap();
            CreateMap<Usuarios, UsuariosUpdateDTO>().ReverseMap();
        }
    }
}
