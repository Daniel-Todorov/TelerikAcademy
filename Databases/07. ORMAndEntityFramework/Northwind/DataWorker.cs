//02. Create a DAO class with static methods which 
//provide functionality for inserting, modifying and 
//deleting customers. Write a testing class.

//03. Write a method that finds all customers who have 
//orders made in 1997 and shipped to Canada.

//05. Write a method that finds all the sales by specified 
//region and period (start / end dates).

//09. Create a method that places a new order in the 
//Northwind database. The order should contain 
//several order items. Use transaction to ensure the 
//data consistency.

//10 .Create a stored procedures in the Northwind
//database for finding the total incomes for given 
//supplier name and period (start date, end date). 
//Implement a C# method that calls the stored 
//procedure and returns the retuned record set.

//NOTE!!! Testing is in EntryPoint class

namespace Northwind
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Text;

    public class DataWorker
    {
        public static Northwind.usp_GetTotalIncome_Result GetAllIncome(string companyName, DateTime startDate, DateTime endDate, NorthwindEntities context)
        {
            //NOTE!!!
            //Make sure you execute this script only once and update your C# database model with the new prcedure
            context.Database.ExecuteSqlCommand("CREATE PROCEDURE [usp_GetTotalIncome] " +
                    "(@companyName nvarchar(40), @dateStart datetime, @dateEnd datetime) " +
                "AS " +
                "SELECT s.CompanyName, " +
                "SUM(p.UnitsInStock * p.UnitPrice) AS Reveniew " +
                    "FROM Suppliers s " +
                    "INNER JOIN Products p " +
                        "ON s.SupplierID = p.SupplierID " +
                    "WHERE s.CompanyName = @companyName " +
                    "GROUP BY s.SupplierID, s.CompanyName");
            context.SaveChanges();
            
            var result = context.usp_GetTotalIncome(companyName, startDate, endDate).FirstOrDefault();
            return result;
        }

        public static void InsertOrders(NorthwindEntities context, params Order[] orders)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    int numberOfOrders = orders.Length;

                    for (int i = 0; i < numberOfOrders; i++)
                    {
                        context.Orders.Add(orders[i]);
                    }

                    context.SaveChanges();
                    transaction.Commit();
                    Console.WriteLine("Orders added.");
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    Console.WriteLine("Orders NOT added.");
                }
            }
        }

        public static List<Order> GetSalesByReagionAndPeriod(string region, DateTime startDate, DateTime endDate, NorthwindEntities context)
        {
            var result = context.Orders
                .Where(order => order.ShipRegion.Equals(region)
                    && ((DateTime)order.OrderDate) > startDate
                    && ((DateTime)order.OrderDate) < endDate)
                .ToList();

            return result;
        }

        public static List<Customer> GetCustomersByYearAndDestinationOfOrder(string year, string destination, NorthwindEntities context)
        {
            var result = context.Customers
                .Where(customer => customer
                    .Orders
                        .Any(order =>
                            order.ShipCountry.Equals(destination)
                            && ((DateTime)order.OrderDate).Year.ToString().Equals(year)))
                .ToList();

            return result;
        }

        public static void AddCustomer(Customer customer, NorthwindEntities context)
        {
            context.Customers.Add(customer);

            context.SaveChanges();
        }

        public static void DeleteCustomer(string customerID, NorthwindEntities context)
        {
            var customerToDelete = context.Customers.Where(customer => customer.CustomerID == customerID).FirstOrDefault();

            context.Customers.Remove(customerToDelete);

            context.SaveChanges();
        }

        public static void UpdateCustomerName(string customerID, string customerName, NorthwindEntities context)
        {
            var customerToUpdate = context.Customers.Where(customer => customer.CustomerID.Equals(customerID)).FirstOrDefault();

            customerToUpdate.CompanyName = customerName;

            context.SaveChanges();
        }
    }
}
