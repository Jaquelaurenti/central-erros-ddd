using AutoMapper;
using CentralErrosDDD.Application.Dtos;
using CentralErrosDDD.Domain.Entitys;

namespace CentralErrosDDD.Application.Mappers
{
    public class DtoToModelMappingEnvironment : Profile
    {
        public DtoToModelMappingEnvironment()
        {
            EnvironmentDto();
        }

        private void EnvironmentDto()
        {
            CreateMap<EnvironmentDTO, Environment>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Name, opt => opt.MapFrom(x => x.Name));
        }
    }
}
