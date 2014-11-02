using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Product : IComparable
    {
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(object obj)
        {
            Product itemToCompareTo;

            try
            {
                itemToCompareTo = (Product)obj;
            }
            catch (Exception)
            {
                throw new ArgumentException("These objects can't be compared");
            }

            if (this.Price > itemToCompareTo.Price)
            {
                return 1;
            }
            else if (this.Price < itemToCompareTo.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

