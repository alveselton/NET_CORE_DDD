using Autofac;
using CoreDDDRestApi.Application.Interfaces;
using CoreDDDRestApi.Application.Services;
using CoreDDDRestApi.Domain.Core.Interfaces.Repositories;
using CoreDDDRestApi.Domain.Core.Interfaces.Services;
using CoreDDDRestApi.Infrastructure.CrossCutting.Adapter.Interfaces;
using CoreDDDRestApi.Infrastructure.CrossCutting.Adapter.Map;
using CoreDDDRestApi.Infrastructure.Services.Services;
using CoreDDDRestApi.Infrastruture.Repository.Repositories;
using System;

namespace CoreDDDRestApi.Infrastruture.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<IServiceProduto>().As<IServiceProduto>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();
            #endregion

            #endregion

        }
    }
}
