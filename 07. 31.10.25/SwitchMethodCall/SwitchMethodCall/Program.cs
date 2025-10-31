namespace SwitchMethodCall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //teha switchi rakendus,
            //kus kasutaja sisestab sõiduki tüübi (coipe või truck)
            //ja programm kutsub vastava meetodi (CarCoupe või Truck)

            string car = Console.ReadLine();

            switch (car)
            {
                case "Car Coupe":
                    CarCoupe();
                    break;

                case "Truck":
                    Truck();
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }

        }

        static void CarCoupe()
        {
            Console.WriteLine("This is a coupe car.");
        }

        static void Truck()
        {
            Console.WriteLine("This is a truck");
        }
    }
}
