namespace _02.Salaries
{
    using System.Collections.Generic;

    public class Employee
    {
        public Employee()
        {
            this.Employees = new List<Employee>();
        }

        public List<Employee> Employees { get; set; }
        public int Salary
        {
            get
            {
                if (this.Employees.Count == 0)
                {
                    return 1;
                }
                else
                {
                    int salary = 0;
                    foreach (var employee in this.Employees)
                    {
                        salary += employee.Salary;
                    }

                    return salary;
                }
            }
        }
    }
}
