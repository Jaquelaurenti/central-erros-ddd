using AutoMapper;
using CentralErrosDDD.Application.Dtos;
using CentralErrosDDD.Application.Interfaces;
using CentralErrosDDD.Domain.Core.Interfaces.Services;
using CentralErrosDDD.Domain.Entitys;
using System.Collections.Generic;

namespace CentralErrosDDD.Application
{
    public class ApplicationServiceErrorOcurrence : IApplicationServiceErrorOcurrence
    {
        private readonly IServiceErrorOcurrence serviceErrorOcurrence;
        private readonly IMapper mapper;
        public ApplicationServiceErrorOcurrence(IServiceErrorOcurrence serviceErrorOcurrence
                                       , IMapper mapper)
        {
            this.serviceErrorOcurrence = serviceErrorOcurrence;
            this.mapper = mapper;
        }
        public void Add(ErrorOcurrenceDTO errorDto)
        {
            var error = mapper.Map<ErrorOcurrence>(errorDto);
            serviceErrorOcurrence.Add(error);
        }     

        public ErrorOcurrenceDTO GetById(int id)
        {
            var error = serviceErrorOcurrence.GetById(id);
            var errorDto = mapper.Map<ErrorOcurrenceDTO>(error);

            return errorDto;
        }

        public void Remove(ErrorOcurrenceDTO errorDto)
        {
            var error = mapper.Map<ErrorOcurrence>(errorDto);
            serviceErrorOcurrence.Remove(error);
        }

        public void Update(ErrorOcurrenceDTO errorDto)
        {
            var error = mapper.Map<ErrorOcurrence>(errorDto);
            serviceErrorOcurrence.Update(error);
        }

        IEnumerable<ErrorOcurrenceDTO> IApplicationServiceErrorOcurrence.GetAll()
        {
            var errors = serviceErrorOcurrence.GetAll();
            var errorsDtos = mapper.Map<IEnumerable<ErrorOcurrenceDTO>>(errors);

            return errorsDtos;

        }
    }
}
