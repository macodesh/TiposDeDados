// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n--------------------");
Console.WriteLine("Números de ponto flutuante");
Console.WriteLine("--------------------\n");

float valor11 = 1.23f;
double valor12 = 1.2345;
decimal valor13 = 1.234567890m;

Console.WriteLine("float: " + valor11);
Console.WriteLine("double: " + valor12);
Console.WriteLine("decimal: " + valor13);

float divisao1 = valor11 / 3;
double divisao2 = valor12 / 3;
decimal divisao3 = valor13 / 3;

Console.WriteLine(
    $@"
Resultados:

Divisão de float: {divisao1}
Divisão de double: {divisao2}
Divisão de decimal: {divisao3}"
);

Console.ReadKey();
