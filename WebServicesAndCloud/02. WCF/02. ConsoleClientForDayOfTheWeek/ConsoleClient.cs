namespace _02.ConsoleClientForDayOfTheWeek
{
    using _02.ConsoleClientForDayOfTheWeek.DayOfTheWeekService;
    using System;
    using System.Text;

    public class ConsoleClient
    {
        public static void Main()
        {
            

            DayOfWeekServiceClient service = new DayOfWeekServiceClient();
            string dayOfWeekInBulgarian = service.GetDayOfWeekInBulgarian(DateTime.Now);

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Днес е {0}", dayOfWeekInBulgarian);
        }
    }
}
