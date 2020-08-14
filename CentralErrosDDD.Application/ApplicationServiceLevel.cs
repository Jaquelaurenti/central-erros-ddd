using AutoMapper;
using CentralErrosDDD.Application.Dtos;
using CentralErrosDDD.Application.Interfaces;
using CentralErrosDDD.Domain.Core.Interfaces.Services;
using CentralErrosDDD.Domain.Entitys;
using System.Collections.Generic;

namespace CentralErrosDDD.Application
{
    public class ApplicationServiceLevel : IApplicationServiceLevel
    {
        private readonly IServiceLevel serviceLevel;
        private readonly IMapper mapper;
        public ApplicationServiceLevel(IServiceLevel serviceLevel
                                       , IMapper mapper)
        {
            this.serviceLevel = serviceLevel;
            this.mapper = mapper;
        }
        public void Add(LevelDTO levelDTO)
        {
            var level = mapper.Map<Level>(levelDTO);
            serviceLevel.Add(level);
        }     

        public LevelDTO GetById(int id)
        {
            var level = serviceLevel.GetById(id);
            var levelDto = mapper.Map<LevelDTO>(level);

            return levelDto;
        }

        public void Remove(LevelDTO levelDTO)
        {
            var level = mapper.Map<Level>(levelDTO);
            serviceLevel.Remove(level);
        }

        public void Update(LevelDTO levelDTO)
        {
            var level = mapper.Map<Level>(levelDTO);
            serviceLevel.Update(level);
        }

        IEnumerable<LevelDTO> IApplicationServiceLevel.GetAll()
        {
            var levels = serviceLevel.GetAll();
            var levelsDtos = mapper.Map<IEnumerable<LevelDTO>>(levels);

            return levelsDtos;

        }
    }
}
