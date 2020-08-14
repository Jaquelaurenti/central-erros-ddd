using Autofac;
using AutoMapper;
using CentralErrosDDD.Application;
using CentralErrosDDD.Application.Interfaces;
using CentralErrosDDD.Application.Mappers;
using CentralErrosDDD.Domain.Core.Interfaces.Repositorys;
using CentralErrosDDD.Domain.Core.Interfaces.Services;
using CentralErrosDDD.Domain.Services;
using CentralErrosDDD.Infrastructure.Data.Repositorys;

namespace CentralErrosDDD.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceEnvironment>().As<IApplicationServiceEnvironment>();
            builder.RegisterType<ApplicationServiceLevel>().As<IApplicationServiceLevel>();
            builder.RegisterType<ApplicationServiceErrorOcurrence>().As<IApplicationServiceErrorOcurrence>();

            builder.RegisterType<ServiceEnvironment>().As<IServiceEnvironment>();
            builder.RegisterType<ServiceLevel>().As<IServiceLevel>();
            builder.RegisterType<ServiceErrorOcurrence>().As<IServiceErrorOcurrence>();


            builder.RegisterType<RepositoryEnvironment>().As<IRepositoryEnvironment>();
            builder.RegisterType<RepositoryLevel>().As<IRepositoryLevel>();
            builder.RegisterType<RepositoryErrorOcurrence>().As<IRepositoryErrorOcurrence>();

            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DtoToModelMappingErrorOcurrence());
                cfg.AddProfile(new ModelToDtoMappingErrorOcurrence());


                cfg.AddProfile(new DtoToModelMappingLevel());
                cfg.AddProfile(new ModelToDtoMappingLevel());


                cfg.AddProfile(new DtoToModelMappingEnvironment());
                cfg.AddProfile(new ModelToDtoMappingEnvironment());

            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }

        #endregion IOC
    }

}