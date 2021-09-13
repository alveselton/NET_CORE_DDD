using CoreDDDRestApi.Application.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDDDRestApi.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDTO obj);

        ProdutoDTO GetById(int id);

        IEnumerable<ProdutoDTO> GetAll();

        void Update(ProdutoDTO obj);

        void Remove(ProdutoDTO obj);

        void Dispose();

    }
}
