using CoreDDDRestApi.Application.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDDDRestApi.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDTO obj);

        ClienteDTO GetById(int id);

        IEnumerable<ClienteDTO> GetAll();

        void Update(ClienteDTO obj);

        void Remove(ClienteDTO obj);

        void Dispose();

    }
}
