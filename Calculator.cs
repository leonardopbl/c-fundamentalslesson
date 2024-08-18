namespace Wellcome
{
    public class Calculator
    {
        public static double UniversalCalculator(double a, double b, string operation)
        {
            switch (operation)
            {
                case "+":
                    return a + b;
                case "-":
                    if (a < b)
                    {
                        return b - a;
                    }
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    if (b == 0)
                    {
                        return a;

                    }
                    return a / b;
                case "media":
                    return (a + b) / 2;
                default:
                    return 0;
            }
        }
    }
}