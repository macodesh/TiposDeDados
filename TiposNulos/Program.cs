// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n--------------------");
Console.WriteLine("Tipos nuláveis");
Console.WriteLine("--------------------\n");

Nullable<int> valorNulo = null;
Console.WriteLine("Valor de \"valorNulo\": " + valorNulo);

bool? nulo = null;
Console.WriteLine("Valor de \"nulo\": " + nulo);

int? x = null;
int y = x ?? 0;
Console.WriteLine("Valor de y: " + y);

int? valor1 = 1;
int? valor2 = 2;
int? soma = valor1 + valor2;

if (soma.HasValue)
{
    Console.WriteLine($"Soma: {soma}");
}
else
{
    Console.WriteLine("A soma é nula");
}

Console.ReadKey();
