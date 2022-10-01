using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    //Extensions faz uma extensão do método já utilizado, no exemplo abaixo todos os tipos inteiros tem agora a extensão é par
    public static class IntExtensions//static pporque ele não será instanciado
    {
        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
}