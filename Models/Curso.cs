using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }//Lista é uma coleção de um determinado tipo (<Pessoa> neste caso)

        public void AdicionarAluno(Pessoa aluno)//void = vazio, ou seja não retorna nada
        {
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            //chegou ao fim do método e ele vai me retornar o que eu definir
            return quantidade;
        }
    }
}