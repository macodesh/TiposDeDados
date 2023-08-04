// See https://aka.ms/new-console-template for more information
Console.WriteLine("--------------------");
Console.WriteLine("Data e Hora: Struct DateTime");
Console.WriteLine("--------------------\n");

DateTime dataAtual = DateTime.Now;
Console.WriteLine("Data e hora atuais: " + dataAtual.ToString());

DateTime data = new(2023, 07, 19);
Console.WriteLine("Data: " + data);

DateTime dataEHora = new DateTime(2023, 07, 19, 18, 57, 21);
Console.WriteLine("Data e hora: " + dataEHora);

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

Console.WriteLine("\n--------------------\n");
Console.WriteLine("Ano que vem: " + dataAtual.AddYears(1));
Console.WriteLine("Mês seguinte: " + dataAtual.AddMonths(1));
Console.WriteLine("Daqui a 1 dia e meio: " + dataAtual.AddDays(1.5));

Console.WriteLine("\n--------------------\n");
Console.WriteLine("Data em formato longo: " + dataAtual.ToLongDateString());
Console.WriteLine("Data em formato curto: " + dataAtual.ToShortDateString());
Console.WriteLine("Hora em formato longo: " + dataAtual.ToLongTimeString());
Console.WriteLine("Hora em formato curto: " + dataAtual.ToShortTimeString());

Console.ReadKey();
