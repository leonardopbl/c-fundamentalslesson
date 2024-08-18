using Namespace;

namespace Wellcome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //1. Crie um programa em que o usuário precisa digitar um nome e uma mensagem com o nome dele é exibida:  
            // Olá, Welisson! Seja muito bem-vindo! de boas vindas personalizada
            // Console.WriteLine("Olá, qual é o seu nome?");
            // var name = Console.ReadLine();
            // if (name == "")
            // {
            //     Console.WriteLine("Por favor, digite um nome válido");
            //     name = Console.ReadLine();
            // }
            // Console.Clear();
            // Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
            // Thread.Sleep(3000);
            // Console.Clear();
            // //2. Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e 
            // //ao final exiba o nome completo.
            // Console.WriteLine($"{name}, você poderia me dizer seu sobrenome?");
            // var lastName = Console.ReadLine();
            // if (lastName == "")
            // {
            //     Console.WriteLine("Por favor, digite um sobrenome válido");
            //     lastName = Console.ReadLine();
            // }
            // string fullName = name + " " + lastName;
            // Console.WriteLine($"Muito prazer em te conhecer, {fullName} !");
            // Thread.Sleep(2000);
            // Console.Clear();
            Console.WriteLine("Escolha qual programa você gostaria de experimentar:");
            Console.WriteLine("1. Calculadora Universal");
            Console.WriteLine("2. Consultor de Placas");
            Console.WriteLine("3. Modelos de datas");
            var option = Console.ReadLine();
            if (option == "")
            {
                Console.WriteLine("Por favor, escolha uma opção válida");
                option = Console.ReadLine();
            }
            switch (option)
            {
                case "1":
                    Console.Clear();
                    UniversalCalculator.Program(args);
                    break;
                case "2":
                    Console.Clear();
                    PlateConsulting.Program(args);
                    break;
                case "3":
                    Console.Clear();
                    DateModels.Program(args);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        }
    }
}