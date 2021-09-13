using CoreDDDRestApi.Application.DTO.DTO;
using CoreDDDRestApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDDDRestApi.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperProduto
    {
        #region Interfaces Mappers
        Produto MapperToEntity(ProdutoDTO produtoDTO);

        IEnumerable<ProdutoDTO> MapperListProdutos(IEnumerable<Produto> clientes);

        ProdutoDTO MapperToDTO(Produto produto);

        #endregion

    }
}
