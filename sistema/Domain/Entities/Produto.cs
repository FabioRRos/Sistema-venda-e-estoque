using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema.Domain.Entities
{
    public class Produto
    {
        public int CodProduto { get; set; }
        public int CodBarrasProduto { get; set; }
        public string? NomeProduto { get; set; }
        public int QuantidadeProduto { get; set; }
        public double PrecoProduto { get; set; }
        public int CodGrupoProduto { get; set; }
        public string? NomeGrupoProduto { get; set; }
        public string? DescricaoProduto { get; set; }


    }
}