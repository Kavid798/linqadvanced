using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;
namespace linqadvanced
{
    class NorthWind
    {
        static void Main(string[] args)
        {
            NorthwindEntities db = new NorthwindEntities();
           List<Employee> employees=db.Employees.ToList();
            ArrayList emps = new ArrayList(db.Employees.ToArray());
            var emp = from e in emps.OfType<Employee>() select e;
            foreach(var item in emp)
            {
                Console.WriteLine(item.City);
            }

          
           


            //var output = from e in db.Employees
            //             join  o in db.Orders on
            //          e.EmployeeID equals o.EmployeeID
            //             select new
            //             {
            //                 EmployeeName = e.FirstName + " " + e.LastName,
            //                 Citys = e.City,
            //                 Countrys = e.Country,
            //                 ShipCitys = o.ShipCity,
            //                 ShipCountrys = o.ShipCountry
            //             };
            //var table = new ConsoleTable("EmployeeName", "Citys", "Countrys", "ShipCitys", "ShipCountrys");
            //foreach(var item in output)
            //{
            //    table.AddRow(item.EmployeeName, item.Citys, item.Countrys, item.ShipCitys, item.ShipCountrys);
            //}
            //table.Write();

        }
      
    }
}
