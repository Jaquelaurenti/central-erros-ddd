using AutoMapper;
using CentralErrosDDD.Application.Dtos;
using CentralErrosDDD.Domain.Entitys;

namespace CentralErrosDDD.Application.Mappers
{
    public class ModelToDtoMappingEnvironment : Profile
    {

        public ModelToDtoMappingEnvironment()
        {
            EnvironmentDtoMap();
        }

        private void EnvironmentDtoMap()
        {
            CreateMap<Environment, EnvironmentDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name));
        }
    }
}
