//01. Using the Visual Studio Entity Framework designer 
//create a DbContext for the Northwind database.

//04. Implement previous by using native SQL query and 
//executing it through the DbContext.

namespace Northwind
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Text;
    using System.Data.Entity.Core.Objects;

    class EntryPoint
    {
        static void Main()
        {
            var northwind = new NorthwindEntities();


            using (northwind)
            {
                DataWorker.UpdateCustomerName("ALFKI", "Telerik", northwind);
                Console.WriteLine(northwind.Customers.Where(customer => customer.CustomerID == "ALFKI").FirstOrDefault().CompanyName);

                DataWorker.AddCustomer(new Customer() { CustomerID = "DDDDD", CompanyName = "Monsters Inc" }, northwind);
                Console.WriteLine(northwind.Customers.Where(customer => customer.CustomerID == "DDDDD").FirstOrDefault().CompanyName);

                DataWorker.DeleteCustomer("DDDDD", northwind);
                Console.WriteLine(northwind.Customers.Any(customer => customer.CustomerID == "DDDDD"));

                //All custemers from Canada and made orders in 1997
                var selectedCustomers = DataWorker.GetCustomersByYearAndDestinationOfOrder("1997", "Canada", northwind);

                Console.WriteLine();
                Console.WriteLine("Customers from Canada, made roders in 1997:");

                foreach (var customer in selectedCustomers)
                {
                    Console.WriteLine(customer.CompanyName);
                }

                Console.WriteLine();
                //---------------------------------------------------

                //Using native query to get customers
                var nativeQueryCustomers = northwind.Database.SqlQuery<Customer>("SELECT c.CompanyName, c.Address, c.City, c.ContactName, c.ContactTitle, c.Country, c.CustomerID, c.Fax, c.Phone, c.PostalCode, c.Region FROM Customers c INNER JOIN Orders o ON c.CustomerID = o.CustomerID WHERE o.ShipCountry = 'Canada' AND o.OrderDate BETWEEN Convert(datetime, '1996-12-31') AND Convert(datetime, '1998-01-01' ) GROUP BY c.CompanyName, c.Address, c.City, c.ContactName, c.ContactTitle, c.Country, c.CustomerID, c.Fax, c.Phone, c.PostalCode, c.Region").ToList();

                Console.WriteLine();
                Console.WriteLine("Customers from Canada, made roders in 1997:");

                foreach (var customer in selectedCustomers)
                {
                    Console.WriteLine(customer.CompanyName);
                }

                Console.WriteLine();
                //---------------------------------------------------

                //Getting orders by date and region
                var selectedOrders = DataWorker.GetSalesByReagionAndPeriod("AK", DateTime.Parse("1996.01.01"), DateTime.Parse("1998.01.01"), northwind);

                Console.WriteLine();
                Console.WriteLine("Orders with region AK and between 01.01.1996 and 01.01.1998:");

                foreach (var order in selectedOrders)
                {
                    Console.WriteLine(order.OrderID);
                }

                Console.WriteLine();
                //---------------------------------------------------

                //Inserting several orders
                DataWorker.InsertOrders(northwind, new Order(), new Order(), new Order());

                //Get all income of Company
                var setOfData = DataWorker.GetAllIncome("Exotic Liquids", DateTime.Parse("1990.01.01"), DateTime.Parse("2000.01.01"), northwind);

                Console.WriteLine("{0} : {1}", setOfData.CompanyName, setOfData.Reveniew);
                Console.WriteLine();
                //---------------------------------------------------
            }

            //07. Try to open two different data contexts and perform 
            //concurrent changes on the same records. What will 
            //happen at SaveChanges()? How to deal with it?

            //Well, it happens whatever is expected to happen - the updates are executed in the order they have in the C# code.
            // First the name turns to Piglet and then to Bunny.
            using (var northwindEntities1 = new NorthwindEntities())
            {
                using (var northwindEntities2 = new NorthwindEntities())
                {
                    DataWorker.UpdateCustomerName("ALFKI", "Piglet", northwindEntities2);
                    DataWorker.UpdateCustomerName("ALFKI", "Bunny", northwindEntities1);

                    northwindEntities1.SaveChanges();
                    northwindEntities2.SaveChanges();
                }
            }
        }


    }
}
