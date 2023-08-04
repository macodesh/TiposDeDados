// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n--------------------");
Console.WriteLine("Booleanos e caracteres");
Console.WriteLine("--------------------\n");

bool ativo = true;
bool inativo = false;
bool comparacao = 10 == 15;

Console.WriteLine($"Valores booleanos: {ativo}, {inativo} e a comparação: 10 é igual a 15? {comparacao}");

char letra = 'a';
char unicode = '\u0041';

Console.WriteLine($"Letra: {letra} e unicode: {unicode}");

Console.ReadKey();
