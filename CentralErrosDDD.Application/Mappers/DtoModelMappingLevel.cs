using AutoMapper;
using CentralErrosDDD.Application.Dtos;
using CentralErrosDDD.Domain.Entitys;

namespace CentralErrosDDD.Application.Mappers
{
    public class DtoToModelMappingLevel : Profile
    {
        public DtoToModelMappingLevel()
        {
            LevelDto();
        }

        private void LevelDto()
        {
            CreateMap<LevelDTO, Level>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name));
        }
    }
}
