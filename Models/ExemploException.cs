using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class ExemploException
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }catch(Exception ex)
            {
                Console.WriteLine("Exceção tratada. Mensagem: " + ex.Message);
            }
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção");//throw = lançar. Nesse caso vai lançar a exceção de volta até que alguém "pegue (catch)". Se não tiver nenhum catch o programa será encerrado.
        }
    }
}