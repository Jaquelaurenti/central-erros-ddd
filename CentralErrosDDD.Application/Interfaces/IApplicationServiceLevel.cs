using CentralErrosDDD.Application.Dtos;
using System.Collections.Generic;

namespace CentralErrosDDD.Application.Interfaces
{
    public interface IApplicationServiceLevel
    {
        void Add(LevelDTO levelDTO);

        void Update(LevelDTO levelDTO);

        void Remove(LevelDTO levelDTO);

        IEnumerable<LevelDTO> GetAll();

        LevelDTO GetById(int id);
    }
}