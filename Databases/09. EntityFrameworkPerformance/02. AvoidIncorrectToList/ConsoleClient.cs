//Using Entity Framework write a query that selects all
//employees from the TelerikAcademy database, then
//invokes ToList(), then selects their addresses, then
//invokes ToList(), then selects their towns, then
//invokes ToList(), and finally checks whether the
//the town is "Sofia". Rewrite the same in more optimised
//way and compare the performance.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

using _01.UseInclude;
using System.Diagnostics;

namespace _02.AvoidIncorrectToList
{
    public class ConsoleClient
    {
        static void Main()
        {
            var db = new TelerikAcademyEntities();
            Stopwatch watch = new Stopwatch();

            //Try with many ToList()
            watch.Start();
            var employees = db.Employees.ToList()
                .Select(employee => employee.Address).ToList()
                .Select(address => address.Town).ToList()
                .Where(town => town.Name.Equals("Sofia")).ToList();
            watch.Stop();

            var performanceWithManyListings = watch.Elapsed;

            watch.Reset();

            //Try with single ToList()
            watch.Start();
            employees = db.Employees
                .Select(employee => employee.Address)
                .Select(address => address.Town)
                .Where(town => town.Name.Equals("Sofia")).ToList();
            watch.Stop();

            var performanceWithSingleListing = watch.Elapsed;

            //Performance result
            Console.WriteLine("Performance with many ToList(): {0}{1}Performance with single ToList(): {2}", performanceWithManyListings, Environment.NewLine, performanceWithSingleListing);
            //Second option is about 7 times faster!
        }
    }
}
