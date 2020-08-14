using AutoMapper;
using CentralErrosDDD.Application.Dtos;
using CentralErrosDDD.Domain.Entitys;

namespace CentralErrosDDD.Application.Mappers
{
    public class ModelToDtoMappingErrorOcurrence : Profile
    {
        public ModelToDtoMappingErrorOcurrence()
        {
            ErrorOcurrenceDtoMap();
        }
        private void ErrorOcurrenceDtoMap()
        {
            CreateMap<ErrorOcurrence, ErrorOcurrenceDTO>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Title, opt => opt.MapFrom(x => x.Title))
                .ForMember(dest => dest.RegistrationDate, opt => opt.MapFrom(x => x.RegistrationDate))
                .ForMember(dest => dest.Origin, opt => opt.MapFrom(x => x.Origin))
                .ForMember(dest => dest.Filed, opt => opt.MapFrom(x => x.Filed))
                .ForMember(dest => dest.Details, opt => opt.MapFrom(x => x.Details))
                .ForMember(dest => dest.Username, opt => opt.MapFrom(x => x.Username))
                .ForMember(dest => dest.EventId, opt => opt.MapFrom(x => x.EventId))
                .ForMember(dest => dest.EnvironmentId, opt => opt.MapFrom(x => x.EnvironmentId))
                .ForMember(dest => dest.LevelId, opt => opt.MapFrom(x => x.LevelId));
        }
    }
}
