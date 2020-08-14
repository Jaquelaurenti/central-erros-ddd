using CentralErrosDDD.Domain.Core.Interfaces.Repositorys;
using CentralErrosDDD.Domain.Entitys;

namespace CentralErrosDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryLevel : RepositoryBase<Level>, IRepositoryLevel
    {
        private readonly SqlContext sqlContext;

        public RepositoryLevel(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}