// See https://aka.ms/new-console-template for more information
Console.WriteLine("--------------------");
Console.WriteLine("Números inteiros");
Console.WriteLine("--------------------\n");

byte valor1 = 255;
sbyte valor2 = -127;
int valor3 = -214783647;
uint valor4 = 214783647;
long valor5 = -2147836479845670;

const ulong Valor6 = 2147836479845670;

short valor7 = -10000;
ushort valor8 = 10000;

valor4 = 1000000000;

int valor9 = 9, valor10 = 10;

Console.WriteLine("byte: " + valor1);
Console.WriteLine("sbyte: " + valor2);
Console.WriteLine("int: " + valor3);
Console.WriteLine("uint: " + valor4);
Console.WriteLine("long: " + valor5);
Console.WriteLine("ulong: " + Valor6);
Console.WriteLine("short: " + valor7);
Console.WriteLine("ushort: " + valor8);
Console.WriteLine($"Números inteiros: {valor9}, {valor10}");

Console.ReadKey();
