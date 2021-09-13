using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDDDRestApi.Application.DTO.DTO
{
    public class ProdutoDTO
    {
        public int? Id { get; set; }

        public string Nome { get; set; }

        public decimal Valor { get; set; }
    }
}
