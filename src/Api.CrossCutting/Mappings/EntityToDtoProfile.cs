using Api.Domain.Dtos.Cep;
using Api.Domain.Dtos.Municipio;
using Api.Domain.Dtos.Uf;
using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<UserDto, UserEntity>()
               .ReverseMap();

            CreateMap<UserDtoCreateResult, UserEntity>()
               .ReverseMap();

            CreateMap<UserDtoUpdateResult, UserEntity>()
               .ReverseMap();

            CreateMap<UfDto, UfEntity>()
               .ReverseMap();

            CreateMap<MunicipioDto, MunicipioEntity>()
               .ReverseMap();

            CreateMap<MunicipioDtoCompleto, MunicipioEntity>()
               .ReverseMap();

            CreateMap<MunicipioDtoCreateResult, MunicipioEntity>()
               .ReverseMap();

            CreateMap<MunicipioDtoUpdateResult, MunicipioEntity>()
               .ReverseMap();

            CreateMap<CepDto, CepEntity>()
               .ReverseMap();

            CreateMap<CepDtoCreateResult, CepEntity>()
               .ReverseMap();

            CreateMap<CepDtoUpdateResult, CepEntity>()
               .ReverseMap();

        }
    }
}
