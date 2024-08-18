using System.Globalization;

namespace Wellcome
{
    class DateModels
    {
        public static void Program(string[] args)
        {
            Console.WriteLine("Seja bem vindo ao programa de Modelos de Datas!");
            Console.WriteLine("Escolha como voce deseja ver a data de hoje:");
            Console.WriteLine("1. Formato commpleto com o dia da semana, Dia/Mês/Ano HH:MM:SS");
            Console.WriteLine("2. Apenas a data no formato DD/MM/AAAA");
            Console.WriteLine("3. Apenas a hora no formato de 24h HH:MM:SS");
            Console.WriteLine("4. Data com o mês por extenso.");
            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    string dateNowCase1 = DateTime.Now.ToString("dddd, dd/MM/yyyy HH:mm:ss", new CultureInfo("pt-BR"));
                    Console.WriteLine($"Data e hora atual: {dateNowCase1}");
                    break;
                case "2":
                    string dateNowCase2 = DateTime.Now.ToString("dd/MM/yyyy", new CultureInfo("pt-BR"));
                    Console.WriteLine($"Data atual: {dateNowCase2}");
                    break;
                case "3":
                    string dateNowCase3 = DateTime.Now.ToString("HH:mm:ss", new CultureInfo("pt-BR"));
                    Console.WriteLine($"Hora atual: {dateNowCase3}");
                    break;
                case "4":
                    string dateNowCase4 = DateTime.Now.ToString("dd/MMMM/yyy", new CultureInfo("pt-BR"));

                    Console.WriteLine($"Data atual: {dateNowCase4}");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}