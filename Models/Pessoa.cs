using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }//get obtem valor, set atribui valor
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");//exemplo de get
        }
    }
}