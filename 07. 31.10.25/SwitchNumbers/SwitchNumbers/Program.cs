namespace SwitchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //peab saama sisestada numbrit ja muudab selle int andmetüübiks

            //tuleb teha switch, kus on esimene case 10, teine on 20 ja kolmas 30
            //kindlasti tuleb ka default lõppu teha

            int number = Convert.ToInt32(Console.ReadLine());
            
            switch (number)
            {
                case 10:
                    Console.WriteLine("Sisestasid numbri 10");
                    break;

                case 2:
                    Console.WriteLine("Sisestasid numbri 20");
                    break;

                case 30:
                    Console.WriteLine("Sisestasid numbri 30");
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
