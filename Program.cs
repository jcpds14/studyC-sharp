using ExemploExplorando.Models;
using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");//Vai alterar todo sistema para esta localizão (Moedas serão formatadas para este local)

string dataString = "2022-04-170";

bool sucesso = DateTime.TryParseExact(
    dataString, // Pega o nome da variável com a data que você deseja converter
    "yyyy-MM-dd HH:mm", // aqui deve ser informado como a data esta escrita
    CultureInfo.InvariantCulture, // Determina a cultura da região.InvarianteCulture para indiferente
    DateTimeStyles.None, // Estilo da data
    out DateTime data // formato de saída e nome da para ser aplicado na variável
    );

if (sucesso)
{
    Console.WriteLine($"Conversão realizada com sucesso! Data: {data}");
}
else
{
    Console.WriteLine($"{dataString} Não é uma data válida.");
}



















/*
DateTime data = DateTime.Now;

Console.WriteLine(data.ToString("dd/MM/yy HH:mm"));
*/

























/*
decimal valorMonetario = 1582.40M;

Console.WriteLine(valorMonetario.ToString("C2"));

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));
*/



























/*

Pessoa p1 = new Pessoa(nome: "Jean", sobrenome: "Carlos");//parametro adicionado pois criei um construtor na classe pessoa. 
//! Sempre coloque o que cada parametro representa, no caso acima nome: e sobrenome:  isso vai tornar a leitura do código mais fácil e rápida.
Pessoa p2 = new Pessoa();//sem construtor, ideal é usar o exemplo acima pois deixa tudo mais limpo
p2.Nome = "Carimbo";//exemplo de set
p2.Sobrenome = "Da Silva";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Valor = 1586.5M;
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

*/