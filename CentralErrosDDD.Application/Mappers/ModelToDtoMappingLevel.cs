using AutoMapper;
using CentralErrosDDD.Application.Dtos;
using CentralErrosDDD.Domain.Entitys;

namespace CentralErrosDDD.Application.Mappers
{
    public class ModelToDtoMappingLevel : Profile
    {

        public ModelToDtoMappingLevel()
        {
            LevelDtoMap();
        }

        private void LevelDtoMap()
        {
            CreateMap<Level, LevelDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name));
        }
    }
}
