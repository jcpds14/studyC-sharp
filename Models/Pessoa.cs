using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa //public sig. que qualquer um pode acessar esta classe
    {
        public Pessoa()//construtor, deve ter o mesmo nome da classe. Pode ser vazio ou receber parametros. Esse está sem parametro pois nem sempre o vamos ter um valor descrito. mas o ideal é colocar parametros nos construtores.
        {

        }
        public Pessoa(string nome, string sobrenome) //construtor
        {
            //os valores recebidos no construtor vão para onde vou definir abaixo
            Nome = nome;//equivale a propriedade Nome, logo abaixo
            Sobrenome = sobrenome;// equivale a propriedade Sobrenome, abaixo da propriedade Nome
        }
        private string _nome;//private só é permitido acessar dentro da própria classe, não acessíveis externamete.
        private int _idade;
        public string Nome //public sig. que qualquer um pode acessar esta propriedade
        
        { //get obtem valor
            get => _nome.ToUpper();//utilizar => ao invés de return quando tivermos apenas um valor(body expressions)
            //set atribui valor       
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
            
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
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
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");//exemplo de get
        }
    }
}