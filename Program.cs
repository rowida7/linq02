using System.Text.RegularExpressions;
using static LINQ.DataSources.Source;
namespace linq02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1.Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.
            //var sortedProducts = ProductList.OrderBy(p => p.Category)
            //                                 .ThenByDescending(p => p.UnitPrice);

            //foreach (var item in sortedProducts)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q2
            //2.Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.
            //var beverages = ProductList.Where(p=> p.Category == "Beverages").OrderByDescending(p=>p.UnitPrice);
            //foreach (var item in beverages)
            //{
            //    Console.WriteLine($"{item.ProductName} => {item.UnitsInStock}");
            //}
            #endregion

            #region Q3
            //3.Using QUERY SYNTAX with a compound from clause, list all orders placed in 1997
            //or later showing CustomerID and OrderDate.
            //var ordersIn1997 = from c in CustomerList
            //                   from o in c.Orders
            //                   where o.OrderDate >= new DateTime(1997, 1, 1)
            //                   select new { c.CustomerID, o.OrderDate };
            //foreach (var item in ordersIn1997)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q4
            //4.Show position number alongside ProductName
            //var res = ProductList.Select((p, i) => (i+1) +" "+ p.ProductName);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q5
            //5.Sort first by-word length and then by a case -insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sorted = Arr.OrderBy(x => x.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in sorted)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q6
            //6.Create a list of all digits in the array whose second letter is 'i'
            //that is reversed from the order in the original array.
            //string[] words = { "bird", "fish", "apple", "milk", "rice" };
            //var res = words
            //            .Where(w => w[1] == 'i')
            //            .Reverse()
            //            .ToList();

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q7
            //7.Get top 3 most expensive products
            //var highest3Products = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);
            //foreach (var item in highest3Products)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q8
            //8.show page 2 of products, with page size = 5
            //var page2 = ProductList.Skip((2 - 1) * 5).Take(5);
            //foreach (var item in page2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q9
            //9.Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).
            //var productLessThan25 = ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);
            //foreach (var item in productLessThan25)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q10
            //10.Check if ALL products in the"Seafood" category are in stock
            //bool isInStock = ProductList.All(p => p.Category == "Seafood" && p.UnitsInStock > 0);
            //Console.WriteLine(isInStock);

            #endregion

            #region Q11
            //11.Check if the ID list contains 9
            //int[] ids = { 3, 9, 13, 18 };
            //bool contain9 = ids.Contains(9);
            //Console.WriteLine(contain9);
            #endregion

            #region Q12
            //12.Group all products by Category and print each group with its product count.
            //var groups = ProductList.GroupBy(p => p.Category);
            //foreach (var group in groups)
            //{
            //    Console.WriteLine($"{group.Key} - Count: {group.Count()}");
            //}
            #endregion

            #region Q13
            //13.Group products by Category and project only product names per group
            //var groups = ProductList.GroupBy(p => p.Category);
            //foreach (var group in groups)
            //{
            //    Console.WriteLine($"{group.Key}");
            //    foreach (var g in group)
            //    {
            //        Console.WriteLine($"- {g.ProductName}");
            //    }

            //}
            #endregion

            #region Q14
            //14.Find all categories that have MORE THAN 3 products
            //var res = ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 3);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.Key);
            //}
            #endregion

            #region Q15
            //15.Using QUERY SYNTAX, group customers by Country, and for each group select{ Country, Count, TotalOrderValue}.
            //var groups = from c in CustomerList
            //             group c by c.Country
            //             into groupsByCountry
            //             select new
            //             {
            //                 country = groupsByCountry.Key,
            //                 count = groupsByCountry.Count(),
            //                 TotalOrderValue = groupsByCountry
            //                .SelectMany(c => c.Orders)
            //                .Sum(o => o.Total)

            //             };
            //foreach (var item in groups)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q16
            //16.Calculate the total number of units in stock across all products
            //int total = ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine(total);
            #endregion

            #region Q17
            //17.Find the CHEAPEST and MOST EXPENSIVE product prices
            //var cheapest = ProductList.Min(p => p.UnitPrice);
            //var expensive = ProductList.Max(p => p.UnitPrice);

            //Console.WriteLine(cheapest);
            //Console.WriteLine(expensive);
            #endregion

            #region Q18
            //18.Get a distinct list of all product categories
            //var distinct = ProductList.DistinctBy(p => p.Category);
            //foreach (var item in distinct)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q19
            //19.find product IDs that are in setA but NOT in setB
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var res = setA.Except(setB);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q20
            //20.Find countries that appear in list1 but NOT in list2(case -insensitive).
            //string[] list1 = { "Germany", "France", "UK", "Spain" }; 
            //string[] list2 = { "france", "SPAIN", "Italy" };
            //var res = list1.Except(list2, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q21
            //21.Build a Dictionary<int, Product> keyed by ProductID.
            //Then retrieve and print the product with ID = 18.
            //var dictionary = ProductList.ToDictionary(p => p.ProductID);
            //Console.WriteLine(dictionary[18]);
            #endregion

            #region Q22
            //22.Get the first product whose price is greater than$50.
            //var first = ProductList.FirstOrDefault(p => p.UnitPrice > 50);
            //Console.WriteLine(first);
            #endregion

            #region Q23
            //23.Try to get the first product with a price>$500.it returns null instead of throwing.
            //var first = ProductList.FirstOrDefault(p => p.UnitPrice > 500);
            //Console.WriteLine(first);
            #endregion

            #region Q24
            //24.Generate a multiplication table row for 7
            //var table = Enumerable.Range(1, 7).Select(n => $"7 x {n} = {7 * n}");

            //foreach (var row in table)
            //{
            //    Console.WriteLine(row);
            //}
            #endregion

            #region Q25
            //25.Generate even numbers between 1 and 30.
            //var evens = Enumerable.Range(1, 30).Where(n => n % 2 == 0);
            //foreach (var item in evens)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q26
            //26.Concatenate the first 3 product names with the first 3 customer company names into a single sequence.
            //var products = ProductList.Select(p=> new {p.ProductName }).Take(3);
            //var customers = CustomerList.Select(c => new { c.CustomerName }).Take(3);
            //var concat = products.Zip(customers);
            //foreach (var item in concat)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region Q27
            //27.Pair each product with a customer(by position) and produce a string"ProductName sold to CompanyName".
            var products = ProductList.Select(p => new { p.ProductName });
            var customers = CustomerList.Select(c => new { c.CustomerName });
            var concat = products.Zip(customers, (p,c) => $"{p.ProductName} sold to {c.CustomerName}");
            foreach (var item in concat)
            {
                Console.WriteLine(item);
            }
            #endregion


        }
    }
}
