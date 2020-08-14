using CentralErrosDDD.Domain.Core.Interfaces.Repositorys;
using CentralErrosDDD.Domain.Entitys;

namespace CentralErrosDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryErrorOcurrence : RepositoryBase<ErrorOcurrence>, IRepositoryErrorOcurrence
    {
        private readonly SqlContext sqlContext;

        public RepositoryErrorOcurrence(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}