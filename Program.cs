namespace Tilaon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Event;            

            Console.WriteLine("------CALENDAR------");
            Console.WriteLine("--------------------");
            Console.WriteLine("1 - Event ");
            Console.WriteLine("2 - Month / Day / Year");
            Console.WriteLine("3 - Exit");
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter a choices:");
            String choices = Console.ReadLine();

            switch (choices) 
            {
                case "1":
                    Console.Write("ADD EVENT: ");
                    Event = Console.ReadLine();
                    Console.WriteLine("ADD SCHEDULE (MONTH / DAY / YEAR)");
                    String dayss = Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("ADD SCHEDULE (MONTH / DAY / YEAR)");
                    String daysss = Console.ReadLine();
                    Console.Write("ADD EVENT: ");
                    Event = Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Exit");
                    break;
            }
        }
    }
}
