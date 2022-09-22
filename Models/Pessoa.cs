using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa //public sig. que qualquer um pode acessar esta classe
    {
        private string _nome;//private só é permitido acessar dentro da própria classe, não acessíveis externamete.
        private int _idade;
        public string Nome //public sig. que qualquer um pode acessar esta propriedade
        //get obtem valor, set atribui valor
        { 
            get => _nome.ToUpper();//utilizar => ao invés de return quando tivermos apenas um valor(body expressions)
                        
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
            
        }
        public int Idade 
        { 
            get => _idade; 
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");//exemplo de get
        }
    }
}