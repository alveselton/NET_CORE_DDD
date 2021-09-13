using CoreDDDRestApi.Domain.Core.Interfaces.Repositories;
using CoreDDDRestApi.Domain.Core.Interfaces.Services;
using CoreDDDRestApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDDDRestApi.Infrastructure.Services.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        public readonly IRepositoryCliente _repositoryCliente;

        public ServiceCliente(IRepositoryCliente RepositoryCliente)
            : base(RepositoryCliente)
        {
            _repositoryCliente = RepositoryCliente;
        }
    }
}
