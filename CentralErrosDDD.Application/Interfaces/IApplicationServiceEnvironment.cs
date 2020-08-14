using CentralErrosDDD.Application.Dtos;
using System.Collections.Generic;

namespace CentralErrosDDD.Application.Interfaces
{
    public interface IApplicationServiceEnvironment
    {
        void Add(EnvironmentDTO environmentDTO);

        void Update(EnvironmentDTO environmentDTO);

        void Remove(EnvironmentDTO environmentDTO);

        IEnumerable<EnvironmentDTO> GetAll();

        EnvironmentDTO GetById(int id);
    }
}