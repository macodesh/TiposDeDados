// See https://aka.ms/new-console-template for more information
Console.WriteLine("--------------------");
Console.WriteLine("Números inteiros");
Console.WriteLine("--------------------\n");

// Declaração de números inteiros.
// Variáveis seguem o padrão camelCase.

// 8 bits
byte valor1 = 255;

// Signed 8 bits
sbyte valor2 = -127;

// 32 bits
int valor3 = -214783647;

// Unsigned 32 bits
uint valor4 = 214783647;

// 64 bits
long valor5 = -2147836479845670;

// "const" representa uma constante, ou seja, um valor que não pode ser reatribuído.
// Constante seguem o padrão snake_case em letras maíúsculas.
// Ex: MINHA_CONSTANTE.

// Unsigned 64 bits
const ulong VALOR6 = 2147836479845670;

// 16 bits
short valor7 = -10000;

// Unsigned 16 bits
ushort valor8 = 10000;

// É possível reatribuir um valor de mesmo tipo à uma variável.
valor4 = 1000000000;

// Não é possível reatribuir um valor à uma constante.
// VALOR6 = 1;

// É possível declarar várias variáveis um uma única linha, se todas forem de mesmo tipo.
int valor9 = 9, valor10 = 10;

// Classes e métodos seguem o padrão PascalCase.

Console.WriteLine("byte: " + valor1);
Console.WriteLine("sbyte: " + valor2);
Console.WriteLine("int: " + valor3);
Console.WriteLine("uint: " + valor4);
Console.WriteLine("long: " + valor5);
Console.WriteLine("ulong: " + VALOR6);
Console.WriteLine("short: " + valor7);
Console.WriteLine("ushort: " + valor8);
Console.WriteLine($"Números inteiros: {valor9}, {valor10}");

// Essa linha é adicionada para "congelar" o console.
Console.ReadKey();
