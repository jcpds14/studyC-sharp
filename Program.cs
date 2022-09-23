using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Jean";//exemplo de set
p1.Sobrenome = "Carlos";

Pessoa p2 = new Pessoa();
p2.Nome = "Carimbo";//exemplo de set
p2.Sobrenome = "Da Silva";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();