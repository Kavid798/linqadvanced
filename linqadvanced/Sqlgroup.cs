using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;
namespace linqadvanced
{
    class Sqlgroup
    {

        static void Main2(string[] args)
        {
            HRClassDataContext db = new HRClassDataContext();
            //var output = from e in db.Employees
            //             join p in db.Positions

            //             on e.cCurrentPosition equals p.cPositionCode
            //             select new
            //             {
            //                 EmpCode = e.cEmployeeCode,
            //                 FullName = e.vFirstName + " " + e.vLastName,
            //                 City = e.cCity,
            //                 PositionName = p.vDescription,
            //                 Year = p.siYear
            //             };
            ////var table = new ConsoleTable ( "EmpCode", "FullName", "City", "PositionName", "Year" );

            //var table= new ConsoleTable("City", "EmpCount");
            //var output1 = from e in db.Employees
            //              group e by e.cCity into NewGroup
            //              select new
            //              {
            //                  City = NewGroup.Key,
            //                  EmpCount = NewGroup.Count()
            //              };
            //foreach(var item in output1)
            //{
            //    table.AddRow(item.City, item.EmpCount);
            //}
            //table.Write();
            //foreach(var item in output1)
            //{
            //    Console.WriteLine(item.City + "\t" + item.Count + "\t");
            //}
            //foreach (var item in output)
            //{
            //   table.AddRow(item.EmpCode,item.FullName,item.City,item.PositionName,item.Year);
            //}
            //table.Write();
        }
        
    }
}
