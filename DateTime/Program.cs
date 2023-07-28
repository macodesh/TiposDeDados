// See https://aka.ms/new-console-template for more information
Console.WriteLine("--------------------");
Console.WriteLine("Data e Hora: Struct DateTime");
Console.WriteLine("--------------------\n");

// DateTime representa um momento no tempo expresso com data e hora.
// É uma Struct, ou seja, um tipo de dado formado por outros tipos.
// A data e hora são exibidas de acordo com as configurações de localidade do dispositivo.

// Exibe a data e hora atuais.
DateTime dataAtual = DateTime.Now;

// toString é um método que transforma a DateTime em uma string.
Console.WriteLine("Data e hora atuais: " + dataAtual.ToString());

// Cria uma nova data (aaaa, mm, dd).
DateTime data = new(2023, 07, 19);
Console.WriteLine("Data: " + data);

// Cria uma nova data com hora (aaaa, mm, dd, hh, mm, ss).
DateTime dataEHora = new DateTime(2023, 07, 19, 18, 57, 21);
Console.WriteLine("Data e hora: " + dataEHora);

// Métodos de DateTime para obter a data ou hora.

Console.WriteLine("\n--------------------\n");
Console.WriteLine("Ano: " + dataAtual.Year);
Console.WriteLine("Mês: " + dataAtual.Month);
Console.WriteLine("Dia: " + dataAtual.Day);
Console.WriteLine("Hora: " + dataAtual.Hour);
Console.WriteLine("Minutos: " + dataAtual.Minute);
Console.WriteLine("Segundos: " + dataAtual.Second);
Console.WriteLine("Milisegundos: " + dataAtual.Millisecond);
Console.WriteLine("Dia da semana: " + dataAtual.DayOfWeek);
Console.WriteLine("Dia do ano: " + dataAtual.DayOfYear);

// Métodos para adicionar data/hora.
// Existem métodos para adicionar outras partes de data/hora (minutos, segundos, etc).

Console.WriteLine("\n--------------------\n");
Console.WriteLine("Ano que vem: " + dataAtual.AddYears(1));
Console.WriteLine("Mês seguinte: " + dataAtual.AddMonths(1));
Console.WriteLine("Daqui a 1 dia e meio: " + dataAtual.AddDays(1.5));

// Métodos para expressar datas e horas em formato de string.

Console.WriteLine("\n--------------------\n");
Console.WriteLine("Data em formato longo: " + dataAtual.ToLongDateString());
Console.WriteLine("Data em formato curto: " + dataAtual.ToShortDateString());
Console.WriteLine("Hora em formato longo: " + dataAtual.ToLongTimeString());
Console.WriteLine("Hora em formato curto: " + dataAtual.ToShortTimeString());

Console.ReadKey();
