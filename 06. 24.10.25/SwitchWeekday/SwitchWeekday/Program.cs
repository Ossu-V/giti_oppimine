namespace SwitchWeekday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //tuleb kasutada switch lauset
            //kui nädalapäev on esmaspäev, siis prinditakse "Tere esmaspäev"
            //peate kasutama DayOfWeek enumeratsiooni

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Tere esmaspäev");
                    break;

                case DayOfWeek.Tuesday:
                    Console.WriteLine("Tere teisipäev");
                    break;

                case DayOfWeek.Wednesday:
                    Console.WriteLine("Tere kolmapäev");
                    break;

                case DayOfWeek.Thursday:
                    Console.WriteLine("Tere neljapäev");
                    break;

                case DayOfWeek.Friday:
                    Console.WriteLine("Tere reede");
                    break;

                case DayOfWeek.Saturday:
                    Console.WriteLine("Tere laupäev");
                    break;

                case DayOfWeek.Sunday:
                    Console.WriteLine("Tere pühapäev");
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }
                       
        }
    }
}
