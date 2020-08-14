using AutoMapper;
using CentralErrosDDD.Application.Dtos;
using CentralErrosDDD.Application.Interfaces;
using CentralErrosDDD.Domain.Core.Interfaces.Services;
using CentralErrosDDD.Domain.Entitys;
using System.Collections.Generic;

namespace CentralErrosDDD.Application
{
    public class ApplicationServiceEnvironment : IApplicationServiceEnvironment
    {
        private readonly IServiceEnvironment serviceEnvironment;
        private readonly IMapper mapper;
        public ApplicationServiceEnvironment(IServiceEnvironment serviceEnvironment
                                       , IMapper mapper)
        {
            this.serviceEnvironment = serviceEnvironment;
            this.mapper = mapper;
        }
        public void Add(EnvironmentDTO environmentDTO)
        {
            var environment = mapper.Map<Environment>(environmentDTO);
            serviceEnvironment.Add(environment);
        }     

        public EnvironmentDTO GetById(int id)
        {
            var environment = serviceEnvironment.GetById(id);
            var environmentDto = mapper.Map<EnvironmentDTO>(environment);

            return environmentDto;
        }

        public void Remove(EnvironmentDTO environmentDTO)
        {
            var environment = mapper.Map<Environment>(environmentDTO);
            serviceEnvironment.Remove(environment);
        }

        public void Update(EnvironmentDTO environmentDTO)
        {
            var environment = mapper.Map<Environment>(environmentDTO);
            serviceEnvironment.Update(environment);
        }

        IEnumerable<EnvironmentDTO> IApplicationServiceEnvironment.GetAll()
        {
            var environments = serviceEnvironment.GetAll();
            var enviromentsDto = mapper.Map<IEnumerable<EnvironmentDTO>>(environments);

            return enviromentsDto;

        }
    }
}
