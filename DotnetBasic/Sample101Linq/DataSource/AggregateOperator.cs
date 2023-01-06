using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample101Linq.DataSource
{
    public class AggregateOperator
    {
        public List<Product> GetProductList() => Products.ProductList;
        public List<Customer> GetCustomerList() => Customers.CustomerList;
        public int CountSyntax()
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5, 6, 6, 6 };
            int uniqueFactors = factorsOf300.Distinct().Count();
            Console.WriteLine($"There are {uniqueFactors} unique factors of 300.");
            return 0;
        }
        public int CountConditional()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);
            Console.WriteLine("There are {0} odd numbers in the list.", oddNumbers);
            return 0;
        }
        public int CountNested()
        {
            List<Customer> customers = Customers.GetCustomerList();
            /*
            var orderCounts = from c in customers select (c.CustomerID, c.CompanyName, orderCount: c.Orders.Count());

            foreach(var customer in orderCounts)
            {
                Console.WriteLine($"ID: {customer.CustomerID}, Name: {customer.CompanyName}, count: {customer.OrderCount}");
            }
            */

            var orderCounts = from c in customers
                              where c.City.Equals("Berlin")
                              select new
                              {
                                  ID = c.CustomerID,
                                  Name = c.CompanyName,
                                  Count = c.Orders.Count()
                              };
            foreach(var customer in orderCounts)
            {
                Console.WriteLine($"ID: {customer.ID}, Name: {customer.Name}, count: {customer.Count}");
            }
            return 0;
        }
        public int GroupedCount()
        {
            List<Product> products = GetProductList();

            var categoryCounts = from p in products group p by p.Category into g select (Category: g.Key, ProductCount: g.Count());

            foreach(var c in categoryCounts)
            {
                Console.WriteLine($"Category: {c.Category}: Product count:{c.ProductCount}");
            }
            return 0;
        }
        public int SumSyntax()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            double numSum = numbers.Sum();
            Console.WriteLine($"The sum of the numbers is {numSum}");
            return 0;
        }
        public int SumProjection()
        {
            string[] words = { "Cherry", "Apple", "Blueberry" };
            double totalChars = words.Sum(w => w.Length);
            Console.WriteLine($"There are a total of {totalChars} characters in these words");
            return 0;
        }
        public int SumGrouped()
        {
            List<Product> products = GetProductList();
            var categories = from p in products group p by p.Category into g select (Category: g.Key, TotalUnitsInStock: g.Sum(p => p.UnitsInStock));
            foreach(var pair in categories)
            {
                Console.WriteLine($"Category: {pair.Category}, Units in stock: {pair.TotalUnitsInStock}");
            }
            return 0;
        }
        public int MinSyntax()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int minNum = numbers.Min();
            Console.WriteLine($"The minimum number is {minNum}");
            return 0;
        }
        public int MinProjection()
        {
            string[]words = { "Cherry", "Apple", "Blueberry" };
            int shortestWord = words.Min(w => w.Length);
            Console.WriteLine($"The shortest word is {shortestWord} characters long");
            return 0;
        }
        public int MinGrouped()
        {
            List<Product> products = GetProductList();
            var categories = from p in products group p by p.Category into g select (Category: g.Key, CheapestPrice: g.Min(p => p.UnitsInStock));
            foreach (var c in categories)
            {
                Console.WriteLine($"Category: {c.Category}, Lowest price: {c.CheapestPrice}");
            }
            return 0;
        }
        public int MinEachGroup()
        {
            List<Product> products = GetProductList();
            var categories = from p in products group p by p.Category into g let minPrice = g.Min(p=>p.UnitPrice) select (Category: g.Key, CheapestProducts: g.Where(p => p.UnitPrice == minPrice));
            foreach (var c in categories)
            {
                Console.WriteLine($"Category: {c.Category}");
                foreach(var p in c.CheapestProducts)
                {
                    Console.WriteLine($"\tProduct: {p}");
                }
            }
            return 0;
        }
        public int MaxSyntax()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int maxNum = numbers.Max();
            Console.WriteLine($"The minimum number is {maxNum}");
            return 0;
        }
        public int MaxProjection()
        {
            string[] words = { "Cherry", "Apple", "Blueberry" };
            int longestWord = words.Max(w => w.Length);
            Console.WriteLine($"The longest word is {longestWord} characters long");
            return 0;
        }
        public int MaxGrouped()
        {
            List<Product> products = GetProductList();
            var categories = from p in products group p by p.Category into g select (Category: g.Key, MostExpensivePrice: g.Max(p => p.UnitsInStock));
            foreach (var c in categories)
            {
                Console.WriteLine($"Category: {c.Category}, Most expensive product: {c.MostExpensivePrice}");
            }
            return 0;
        }
        public int MaxEachGroup()
        {
            List<Product> products = GetProductList();
            var categories = from p in products group p by p.Category into g let maxPrice = g.Max(p => p.UnitPrice) select (Category: g.Key, MostExpensiveProducts: g.Where(p => p.UnitPrice == maxPrice));
            foreach (var c in categories)
            {
                Console.WriteLine($"Category: {c.Category}");
                foreach (var p in c.MostExpensiveProducts)
                {
                    Console.WriteLine($"\tProduct: {p}");
                }
            }
            return 0;
        }
        public int AverageSyntax()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            double averageNum = numbers.Average();
            Console.WriteLine($"The average number is {averageNum}");
            return 0;
        }
        public int AverageProjection()
        {
            string[] words = { "Cherry", "Apple", "Blueberry" };
            double averageWord = words.Average(w => w.Length);
            Console.WriteLine($"The average word is {averageWord} characters long");
            return 0;
        }
        public int AverageGrouped()
        {
            List<Product> products = GetProductList();
            var categories = from p in products group p by p.Category into g select (Category: g.Key, AveragePrice: g.Average(p => p.UnitsInStock));
            foreach (var c in categories)
            {
                Console.WriteLine($"Category: {c.Category}, Average product: {c.AveragePrice}");
            }
            return 0;
        }
        public int AggregateSyntax()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };
            double product = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);
            Console.WriteLine($"Total product of all numbers: {product}");
            return 0;
        }
        public int SeededAggregate()
        {
            double startBalance = 100.0;
            int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };

            double endBalance = attemptedWithdrawals.Aggregate(startBalance, (balance, nextWithdrawal) => ((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance));
            Console.WriteLine($"Ending balance: {endBalance}");
            return 0;
        }
    }
}
