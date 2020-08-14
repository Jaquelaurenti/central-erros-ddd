using CentralErrosDDD.Application.Dtos;
using System.Collections.Generic;

namespace CentralErrosDDD.Application.Interfaces
{
    public interface IApplicationServiceErrorOcurrence
    {
        void Add(ErrorOcurrenceDTO levelDTO);

        void Update(ErrorOcurrenceDTO levelDTO);

        void Remove(ErrorOcurrenceDTO levelDTO);

        IEnumerable<ErrorOcurrenceDTO> GetAll();

        ErrorOcurrenceDTO GetById(int id);
    }
}