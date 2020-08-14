using CentralErrosDDD.Domain.Core.Interfaces.Repositorys;
using CentralErrosDDD.Domain.Core.Interfaces.Services;
using CentralErrosDDD.Domain.Entitys;

namespace CentralErrosDDD.Domain.Services
{
    public class ServiceEnvironment : ServiceBase<Environment>, IServiceEnvironment
    {
        private readonly IRepositoryEnvironment repositoryEnvironment;

        public ServiceEnvironment(IRepositoryEnvironment repositoryEnvironment)
            : base(repositoryEnvironment)
        {
            this.repositoryEnvironment = repositoryEnvironment;
        }
    }
}