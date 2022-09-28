using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal valor, DateTime dataVenda)
        {
            Id = id;
            Produto = produto;
            Valor = valor;
            DataVenda = dataVenda;
        }
        
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVenda { get; set; }
    }
}