using CoreDDDRestApi.Domain.Core.Interfaces.Repositories;
using CoreDDDRestApi.Domain.Models;
using CoreDDDRestApi.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDDDRestApi.Infrastruture.Repository.Repositories
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {

        private readonly SqlContext _context;
        public RepositoryProduto(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }

    }
}
