namespace ConsoleClientForNumberOfRepetition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ConsoleClient
    {
        public static void Main(){
            GetNumberOfRepetitionsClient service = new GetNumberOfRepetitionsClient();
            string hay = "ahaudha ha hasidjasdn";
            string needle = "ha";

            int numberOfRepetitions = service.GetNumberOfRepetitions(hay, needle);

            Console.WriteLine("{0} contains {1} '{2}' times.", hay, needle, numberOfRepetitions);
        }
    }
}
