namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //loeme kasutaja sisendit ja teisendame selle float tüübiks
            float result = 0;

            Console.WriteLine("Sisesta esimene number");
            float num1 = float.Parse(Console.ReadLine());

            //konsool kirjutab kasutajale , et vali tehe: +, -, *, /

            Console.WriteLine("Sisesta tehe (+, -, *, /");
            string operation = Console.ReadLine();

            //konsool kirjutab, et sisesta teine number ja teisendame selle float tüübiks

            Console.WriteLine("Sisesta teine number");
            float num2 = float.Parse(Console.ReadLine());

            switch (operation)

            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Nulliga jagamine ei ole lubatud!");
                    }
                    else
                    {
                        Console.WriteLine($"Tulemus: {num1 / num2}");
                    }
                    break;

                default:
                    Console.WriteLine("Tundmatu tehe!");
                    break;
            }
            
        }
    }
}
