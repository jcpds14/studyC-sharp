using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");//Vai alterar todo sistema para esta localizão (Moedas serão formatadas para este local)

//!APLICANDO JSON
Venda v1 = new Venda(1, "Material de Escritório", 25.00M);//objeto

string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);























/*
Pessoa p1 = new Pessoa("Jean", "Carlos");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");




//!IF ternário
int numero = 10;
bool ehPar = false;

ehPar = numero % 2 == 0;
Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));




LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");//_(Descartes) na tupla vai descartar esta variável. Serve para o caso de vc não precisar desta informação.

if(sucesso)
{
    //Console.WriteLine("Quantidade de linhas no arquivo: " + quantidadeLinhas); //!É O _(Descartes) ACIMA
    foreach(string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo.");
}




//!TUPLAS
(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Jean", "Carlos", 1.90M);//Forma mais indicada pelo simples motivo de legibilidade
//*Outras Sintaxes de tupla
/*ValueTuple<int, string, string, decimal> outroExemploTupla = (2, "Jamile", "Velame", 1.60M);//Passa o tipo sem nomear os dados
var outroExemploTuplaCreate = Tuple.Create(1, "Jean", "Carlos", 1.90M);//automaticamente identifica o tipo


Console.WriteLine($"Id: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");




//! DICTIONARY
Dictionary<string, string> estados = new Dictionary<string, string>();// Primeiro elemento do Dictionary(chave(key)) deve ser único, senão vai dar uma exceção. O segundo elemento pode se repetir.

estados.Add("BA", "Bahia");//Adicionando elementos ao Dictionary
estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine($"\n Removendo estado BA e alterando valor de SP \n");
estados.Remove("BA");
estados["SP"] = "São Paulo - valor alterado";

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "BA";

Console.WriteLine($"\nVerificando a chave: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente, não é seguro adicionar a chave: {chave}");
}
else
{
    Console.WriteLine($"Valor não existente, é seguro adicionar a chave: {chave}");
}




//!STACK PILHA
Stack<int> pilha = new Stack<int>();
pilha.Push(4);//insere um objeto no topo da pilha
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);
//! Diferente da fila(Queue) a pilha(Stack) quem fica em primeiro é quem entrou por último (Como uma pilha de roupa)

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()} \n");

foreach (int item in pilha)
{
    Console.WriteLine(item);
}




Queue<int> fila = new Queue<int>();//FIFO (first in first out)
fila.Enqueue(6);//adiciona um elemnto na fila
fila.Enqueue(3);
fila.Enqueue(90);
fila.Enqueue(45);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}\n");// fila.Dequeue(); Vai remover SEMPRE o primeiro elemento que entrou na fila

foreach(int item in fila)
{
    Console.WriteLine(item);
}




new ExemploException().Metodo1();




try //afeta muito a performance, deve ser utilizado somente em casos que você não tem controle, como acessar um arquivo por exemplo
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine($"\n {linha} \n");
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu uma exceção. Arquivo não encontrado. {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu uma exceção. Caminho da pasta não encontrado. {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally // útil para por exemplo fechar conexão, independente se der erro ou não
{
    Console.WriteLine("Passou pelo try catch e chegou no finally");
}




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




DateTime data = DateTime.Now;

Console.WriteLine(data.ToString("dd/MM/yy HH:mm"));





decimal valorMonetario = 1582.40M;

Console.WriteLine(valorMonetario.ToString("C2"));

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));




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