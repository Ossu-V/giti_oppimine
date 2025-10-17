namespace SwitchWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int intput = int.Parse(Console.ReadLine());

            switch (intput)
            {
                case 1:
                    Console.Beep();
                    break;

                case 2:
                    Console.Beep();
                    Console.Beep();
                    break;

                case 3:
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
