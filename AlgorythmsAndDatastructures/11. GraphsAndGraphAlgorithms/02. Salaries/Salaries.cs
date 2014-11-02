//NOTE!!! You can test the result here => http://bgcoder.com/Contests/Practice/Index/63#3

namespace _02.Salaries
{
    using System;

    public class Salaries
    {
        public static void Main()
        {
            int numberOfEmployees = int.Parse(Console.ReadLine());

            var graph = new Employee[numberOfEmployees];
            for (int i = 0; i < numberOfEmployees; i++)
            {
                graph[i] = new Employee();
            }

            for (int i = 0; i < numberOfEmployees; i++)
            {
                char[] employeeInfo = Console.ReadLine().ToCharArray();

                for (int j = 0; j < employeeInfo.Length; j++)
                {
                    if (employeeInfo[j] == 'Y')
                    {
                        graph[i].Employees.Add(graph[j]);
                    }
                }
            }

            int totalSalaries = 0;

            for (int i = 0; i < numberOfEmployees; i++)
            {
                totalSalaries += graph[i].Salary;
            }

            Console.WriteLine(totalSalaries);
        }
    }
}
