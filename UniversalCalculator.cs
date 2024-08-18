using Wellcome;

namespace Namespace
{
    public class UniversalCalculator
    {

        public static void Program(string[] args)
        {
            Console.WriteLine("Seja bem-vindo à Calculadora Universal!");
            Console.WriteLine("Por favor, escolha o numero da operação matemática você deseja realizar:");
            Console.WriteLine("1. Adição (+)");
            Console.WriteLine("2. Subtração (-)");
            Console.WriteLine("3. Multiplicação (*)");
            Console.WriteLine("4. Divisão (/)");
            Console.WriteLine("5. Média de dois números");
            var optionChoosing = Console.ReadLine();
            string description = "";
            if (optionChoosing == "")
            {
                Console.WriteLine("Por favor, escolha uma opção válida");
                optionChoosing = Console.ReadLine();
            }
            switch (optionChoosing)
            {
                case "1":
                    optionChoosing = "+";
                    description = "Adição (+)";
                    break;
                case "2":
                    optionChoosing = "-";
                    description = "Subtração (-)";

                    break;
                case "3":
                    optionChoosing = "*";
                    description = "Multiplicação (*)";
                    break;
                case "4":
                    optionChoosing = "/";
                    description = "Divisão (/)";
                    break;
                case "5":
                    optionChoosing = "media";
                    description = "Média de dois números";
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.WriteLine(optionChoosing);
            Console.WriteLine($"Perfeito! Você escolheu a operação {description}.");
            Console.WriteLine("Agora para continuarmos, digite os números que voce deseja calcular separados por ';'.");
            var numbersToCalculated = Console.ReadLine();
            if (numbersToCalculated is not null)
            {
                string[] numbers = numbersToCalculated.Split(";");
                double numberA = double.Parse(numbers[0]);
                double numberB = double.Parse(numbers[1]);
                if (optionChoosing is not null)
                {
                    double result = Calculator.UniversalCalculator(numberA, numberB, optionChoosing);
                    Console.WriteLine($"O resultado da operação {description} entre {numberA} e {numberB} é: {result}");
                }


            }

            Console.WriteLine("Obrigado por usar a Calculadora Universal!");
            Console.WriteLine("Mas antes de ir embora, Nos diga o que achou da nossa calculadora.");
            var feedback = Console.ReadLine();

            if (feedback?.Length > 1)
            {
                var count = 0;
                foreach (var letter in feedback)
                {
                    if (letter == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        count++;
                    }
                }
                Console.WriteLine($"O seu feedback tem {count} caracteres.");
                Console.WriteLine("Obrigado pelo seu feedback!");
            }
            else
            {
                Console.WriteLine("Muito obrigado por usar a Calculadora Universal!");
            }
        }
    }
}