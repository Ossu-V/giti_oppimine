namespace SwitchMultipleCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //sisestad konsooli väärtuse
            //loeb sisestatud väärtuse stringina
            //tuleb kasutada switchi
            //esimeses cases on väärtused "intro to C#", "Variables",
            //"Data Types" ja vastuseks Basic
            //teises cases on väärtused "OOP", "Classes",
            //"Objects" ja vatuseks Intermediate
            //kolmandas cases on väärtused "Asynchronous Programming", "LINQ",
            //"Delegates" ja vastuseks Advanced

            string topic, category;

            topic = Console.ReadLine();


            switch (topic)

            {
                case "intro to C#":
                case "Variables":
                case "Data Types":
                    category = "Basic";
                    break;

                case "OOP":
                case "Classes":
                case "Objects":
                    category = "Intermediate";
                    break;

                case "Asynchronous Programming":
                case "LINQ":
                case "Delegates":
                    category = "Advanced";
                    break;

                default:
                    category = "ERROR";
                    break;
            }
            Console.WriteLine("Category is " + category);

        }
    }
}
