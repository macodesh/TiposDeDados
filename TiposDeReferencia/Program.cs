// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n--------------------");
Console.WriteLine("Tipos de referência: string, object e dynamic");
Console.WriteLine("--------------------\n");

string frase = "Hello, World!";
frase = "Curso de C#";
Console.WriteLine(frase);

object nome = "Marlon Couto";
dynamic idade = 32;
Console.WriteLine(nome + ", " + idade);

Console.ReadKey();
