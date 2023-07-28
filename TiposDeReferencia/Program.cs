// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n--------------------");
Console.WriteLine("Tipos de referência: string, object e dynamic");
Console.WriteLine("--------------------\n");

// Strings precisam ter aspas duplas.
// Strings são imutáveis, ou seja, após declaradas não podem ser alteradas.
string frase = "Hello, World!";

// Reatribuir uma string mantém o endereço de memória do valor anterior.
// Caso vá fazer reatribuir texto com frequência, use o tipo StringBuilder.
frase = "Curso de C#";

Console.WriteLine(frase);

// Object e dynamic suportam todos os tipos de dados.

// Object é útil quando não sabemos o tipo de dado.
object nome = "Marlon Couto";

// Dynamic é útil para recursos avançados, como DLR e Reflection.
dynamic idade = 32;

Console.WriteLine(nome + ", " + idade);

Console.ReadKey();
