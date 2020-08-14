using CentralErrosDDD.Domain.Core.Interfaces.Repositorys;
using CentralErrosDDD.Domain.Core.Interfaces.Services;
using CentralErrosDDD.Domain.Entitys;

namespace CentralErrosDDD.Domain.Services
{
    public class ServiceLevel : ServiceBase<Level>, IServiceLevel
    {
        private readonly IRepositoryLevel repositorLevel;

        public ServiceLevel(IRepositoryLevel repositorLevel)
            : base(repositorLevel)
        {
            this.repositorLevel = repositorLevel;
        }
    }
}