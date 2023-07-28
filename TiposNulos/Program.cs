// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n--------------------");
Console.WriteLine("Tipos nuláveis");
Console.WriteLine("--------------------\n");

// Variáveis de tipo por valor não podem ser nulas.
// Essas variáveis são armazenadas na memória stack.
// Seu valor default é 0, false, etc.
// int x = null vai gerar um erro.
// Um "Nullable Type" é um tipo que pode receber um valor nulo.
// Os valores anuláveis podem receber seus valores normais de tipo mais o valor "null".
// Os tipos anuláveis são diferentes dos seus valores padrão nullable int é diferente de int.

// Nullable<T> <nome> = null;
// Onde T pode ser int, double, float, bool, etc.
Nullable<int> valorNulo = null;

// Não exibirá nada pois seu valor é nulo.
Console.WriteLine("Valor de \"valorNulo\": " + valorNulo);

// A sintaxe simplifica usa o operador "?".
bool? nulo = null;
Console.WriteLine("Valor de \"nulo\": " + nulo);

// O operador de coalescência nula atribui o valor da esquerda de ele não for nulo.
// Caso contrário, atribui o valor da direita.
int? x = null;
int y = x ?? 0;
Console.WriteLine("Valor de y: " + y);

// Um nullable não pode ser operado com um valor não nullable.
// Todos os elementos da operação devem ser convertidos para nullable para isso funcionar.
int? valor1 = 1;
int? valor2 = 2;

int? soma = valor1 + valor2;

// O método "HasValue" checa se o valor é nulo.
// Ele retorna true caso a variável tenha um valor e false caso seja nulo.
if (soma.HasValue)
{
    Console.WriteLine($"Soma: {soma}");
}
else
{
    Console.WriteLine("A soma é nula");
}

Console.ReadKey();
