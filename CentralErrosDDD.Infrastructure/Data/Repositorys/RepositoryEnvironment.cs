using CentralErrosDDD.Domain.Core.Interfaces.Repositorys;
using CentralErrosDDD.Domain.Entitys;

namespace CentralErrosDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryEnvironment : RepositoryBase<Environment>, IRepositoryEnvironment
    {
        private readonly SqlContext sqlContext;

        public RepositoryEnvironment(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}