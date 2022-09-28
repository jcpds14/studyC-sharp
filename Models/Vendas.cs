using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Vendas
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVenda { get; set; }
    }
}