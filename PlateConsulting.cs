using System.Text.RegularExpressions;

namespace Wellcome
{
    class PlateConsulting
    {
        public static void Program(string[] args)
        {
            Console.WriteLine("Seja bem vindo ao Consultor de Placas!");
            Console.WriteLine("Digite a placa que voce deseja consultar de acordo com o padrão XXX-0000");
            var plate = Console.ReadLine();
            if (plate?.Length > 1)
            {
                string upperPlate = plate.ToUpper();
                bool isValid = Regex.IsMatch(upperPlate, @"^[A-Z]{3}-\d{4}$");
                if (isValid)
                {
                    Console.WriteLine("Placa válida!");
                }
                else
                {
                    Console.WriteLine("Placa inválida!");
                }

            }
        }
    }
}