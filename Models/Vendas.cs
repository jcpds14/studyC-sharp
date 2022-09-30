using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploExplorando.Models
{
    public class Vendas
    {
        public int Id { get; set; }
        
        //Atributo. Vai passar um comportamento para a propiedade ou clasee, dizendo que vai ter um comportamento diferente ou representar algo diferente, sem ter que modificar a propiedade. No caso aqui ele diz que tudo no arquivo Json com o nome "Nome_Produto" será modificado no meu sistema C# para propriedade Produto.
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }

        public decimal Valor { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal? Desconto { get; set; }
    }
}