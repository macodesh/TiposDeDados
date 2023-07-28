// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n--------------------");
Console.WriteLine("Números de ponto flutuante");
Console.WriteLine("--------------------\n");

// Declaração de números de ponto flutuante.

// Precisão de 6 a 9 dígitos.
// Tamanho de 4 bytes.
float valor11 = 1.23f;

// Precisão de 15 a 17 dígitos.
// Tamanho de 8 bytes.
// Ideal para cálculos científicos.
double valor12 = 1.2345;

// Precisão de 28 a 29 dígitos.
// Tamanho de 16 bytes.
// Ideal para cálculos financeiros.
decimal valor13 = 1.234567890m;

Console.WriteLine("float: " + valor11);
Console.WriteLine("double: " + valor12);
Console.WriteLine("decimal: " + valor13);

// Observando a precisão dos valores de ponto flutuante.

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
