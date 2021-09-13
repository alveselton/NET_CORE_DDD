using CoreDDDRestApi.Domain.Core.Interfaces.Repositories;
using CoreDDDRestApi.Domain.Core.Interfaces.Services;
using CoreDDDRestApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDDDRestApi.Infrastructure.Services.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        public readonly IRepositoryProduto _repositoryProduto;

        public ServiceProduto(IRepositoryProduto RepositoryProduto)
            : base(RepositoryProduto)
        {
            _repositoryProduto = RepositoryProduto;
        }
    }
}
