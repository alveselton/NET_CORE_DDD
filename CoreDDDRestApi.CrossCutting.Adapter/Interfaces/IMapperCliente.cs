using CoreDDDRestApi.Application.DTO.DTO;
using CoreDDDRestApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDDDRestApi.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperCliente
    {
        #region Mappers

        Cliente MapperToEntity(ClienteDTO clienteDTO);

        IEnumerable<ClienteDTO> MapperListClientes(IEnumerable<Cliente> clientes);

        ClienteDTO MapperToDTO(Cliente Cliente);

        #endregion
    }
}
