using CoreDDDRestApi.Domain.Core.Interfaces.Repositories;
using CoreDDDRestApi.Domain.Models;
using CoreDDDRestApi.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDDDRestApi.Infrastruture.Repository.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext _context;
        public RepositoryCliente(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}
