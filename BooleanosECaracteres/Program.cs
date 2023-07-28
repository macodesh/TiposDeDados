// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n--------------------");
Console.WriteLine("Booleanos e caracteres");
Console.WriteLine("--------------------\n");

// Boolean

// Representam "verdadeiro" ou "falso".
bool ativo = true;
bool inativo = false;

// O resultado de comparações é um valor booleano.
// "==" é o operador de comparação entre dois valores.
bool comparacao = 10 == 15;

Console.WriteLine($"Valores booleanos: {ativo}, {inativo} e a comparação: 10 é igual a 15? {comparacao}");

// Caracteres

// Sempre têm aspas simples.
char letra = 'a';

// Para representar caracteres Unicode use "\u".
char unicode = '\u0041';

Console.WriteLine($"Letra: {letra} e unicode: {unicode}");

Console.ReadKey();
