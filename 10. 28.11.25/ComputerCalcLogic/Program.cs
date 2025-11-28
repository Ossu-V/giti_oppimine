namespace ComputerCalcLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Kui palju on 3 + 8 / (4 - 2) * 4 = ?");

            double calculation1 = 3 + 8 / (4 - 2) * 4;
            float caluclation2 = 3 + 8 / 4 - 2 * 4;
            double caluclation3 = (3 + 8) / (4 - 2) * 4;
            //kui tahad, et võtaks arvesse komakohta, siis pane nr lõppu .0
            double caluclation4 = ((3.0 + 8.0) / (4.0 - 2.0) * 4.0);

            Console.WriteLine("3 + 8 / (4 - 2) * 4 = " + calculation1);
            Console.WriteLine("3 + 8 / 4 - 2 * 4 = " + caluclation2);
            Console.WriteLine("(3 + 8) / (4 - 2) * 4 = " + caluclation3);
            Console.WriteLine("(3 + 8) / (4 - 2) * 4 = " + caluclation3);
        }
    }
}
