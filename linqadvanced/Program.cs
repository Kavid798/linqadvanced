using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqadvanced
{
    public class CustomerDetails

    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
    public class OrderDetails
    { 
        public int ProductID { get; set; }
        public string ProductName { get; set;}
        public DateTime OrderDate { get; set;}

    }

    public class SupplierDetails
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        
        
    }

    class Program
    {
        static void Main1(string[] args)
        {


           List<CustomerDetails> customerDetails = new List<CustomerDetails>()
            {
              new CustomerDetails{CustomerID=1,Name="K",City="Pondicherry"},
               new CustomerDetails{CustomerID=2,Name="D",City="Chennai"},
               new CustomerDetails{CustomerID=3,Name="Sheldon",City="Bangalore"},
               new CustomerDetails{CustomerID=4,Name="Shelly",City="Hyderabad"}
            };
            List<OrderDetails> orderDetails = new List<OrderDetails>()
            {
                new OrderDetails{ProductID=1,ProductName="Tres semme",OrderDate=Convert.ToDateTime("25/02/1998") },
                new OrderDetails{ProductID=2,ProductName="Nivea",OrderDate=DateTime.Now},
                new OrderDetails{ProductID=1,ProductName="Loreal",OrderDate=DateTime.Now},
                new OrderDetails{ProductID=1,ProductName="Pantene",OrderDate=DateTime.Now},
            };
            List<SupplierDetails> supplierDetails = new List<SupplierDetails>()
            {
                new SupplierDetails{SupplierID=1,SupplierName="ABC"},
                new SupplierDetails{SupplierID=2,SupplierName="KZ"}
            };
            //Linq expression
            var result = from c in customerDetails
                         join s in supplierDetails
                         on c.CustomerID equals s.SupplierID
                         join o in orderDetails
                         on c.CustomerID equals o.ProductID
                         select new
                         {
                             CustomerId = c.CustomerID,
                             Names = c.Name,
                             ProdName = o.ProductName,
                             OrderDate=o.OrderDate,
                             SupplierId = s.SupplierID,
                             SupplierNames = s.SupplierName
                         };

                    
            foreach(var item in result)
            {
                Console.WriteLine(item.CustomerId + "\t" + item.Names + "\t"+item.OrderDate+"\t" + item.ProdName + "\t"+item.SupplierId+"\t"+item.SupplierNames);
            }



            //Linq expression
            var output = from c in customerDetails
                         join o in orderDetails
                         on c.CustomerID equals o.ProductID
                         select new
                         {
                             CustomerId = c.CustomerID,
                             Names = c.Name,
                             ProdName = o.ProductName,
                             OrderDates = o.OrderDate
                         };
            //Linq lambda expression
            var output1 = customerDetails.Join(orderDetails, c => c.CustomerID, o => o.ProductID, (c, o) =>
                     new
                     {
                         CustomerId = c.CustomerID,
                         ProductId = o.ProductID,
                         ProdName=o.ProductName,
                         orderDates=o.OrderDate
                     });
            //foreach (var item in output1)
            //{
            //    Console.WriteLine(item.CustomerId + "\t" + item.ProductId + "\t"+item.ProdName+ "\t"+item.orderDates+ "\t");
            //}


            //foreach(var item in output)
            //{
            //    Console.WriteLine(item.CustomerId + "\t" + item.Names + "\t" + item.ProdName + "\t" + item.OrderDates);
            //}










            //ArrayList al = new ArrayList { 10, 20, 20.4f, "Chennai", 56.8f, true, 'M', "Madurai", 'K', "Bangalore" };
            //var result = from list in al.OfType<string>()
            //             select list;
            ////var result = al.OfType<int>();
            //foreach(string item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //var res = from x in al select x;
            //ArrayList arrayList = new ArrayList
            //{
            //    new Customer{CustomerID=1,Name="K",City="Pondicherry"},
            //    new Customer{CustomerID=2,Name="D",City="Chennai"},
            //    new Customer{CustomerID=3,Name="Sheldon",City="Bangaloreai"}
            //};
            //arrayList.Add(10);
            //arrayList.Add(true);
            //arrayList.Add(10.5f);
            //arrayList.Add(50);
            ////Linq query expression
            //var abc = from customer in arrayList.OfType<Customer>()
            //          select customer;
            //linq lambda expression
            //var res = arrayList.OfType<Customer>();
            //foreach (Customer item in res)
            //{
            //    Console.WriteLine(item.CustomerID + " " + item.Name + " " + item.City + " ");
            //}
            //foreach (object item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //var result = from a in arrayList.OfType<int>()
            //             let x = 10
            //             where a >= x
            //             select a;
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);

            //}
            //var res2 = from cust in arrayList.OfType<Customer>()
            //           let c = "rr"
            //           where cust.City.Contains(c)
            //           select new
            //           {
            //               output = cust.City+cust.Name
            //           };
            //select cust.City;


            //var res3 = arrayList.OfType<Customer>()
            //    .Where(c => c.City.Contains("ai"))
            //    .Select(x => new { output = x.City + x.Name });
            //foreach (var item in res3)
            //{
            //    Console.WriteLine(item.output);
            //}

            //var group = arrayList.OfType<Customer>()
            //    .OrderBy(x => x.City)
            //    .GroupBy(c => c.City)
            //    .Select(x => new
            //    {
            //        City = x.Key,
            //        Count = x.Count()
            //    });

            //var grp = from cust in arrayList.OfType<Customer>()
            //          group cust.City by cust.City into NewGroup
            //          select new
            //          {
            //              City = NewGroup.Key,
            //              Count = NewGroup.Count()
            //          };
            //   foreach(var item in grp)
            //{
            //    Console.WriteLine(item.City+"\t"+item.Count);
            //}
            
            //Linq Query expression

        }
    }
}

