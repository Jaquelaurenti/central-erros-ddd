using CentralErrosDDD.Domain.Core.Interfaces.Repositorys;
using CentralErrosDDD.Domain.Core.Interfaces.Services;
using CentralErrosDDD.Domain.Entitys;

namespace CentralErrosDDD.Domain.Services
{
    public class ServiceErrorOcurrence : ServiceBase<ErrorOcurrence>, IServiceErrorOcurrence
    {
        private readonly IRepositoryErrorOcurrence repositoryErrorOcurrence;

        public ServiceErrorOcurrence(IRepositoryErrorOcurrence repositoryErrorOcurrence)
            : base(repositoryErrorOcurrence)
        {
            this.repositoryErrorOcurrence = repositoryErrorOcurrence;
        }
    }
}