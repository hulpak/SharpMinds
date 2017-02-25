using HRM.DAL;
using HRM.DAL.DbContext;
using HRM.DAL.Models;
using System;
using System.Linq;
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork off = new UnitOfWork();

            HRMContext off1 = new HRMContext();
            OfficialHollidays o = new OfficialHollidays {
                Id = 11,
                Name = "Birt",
                Date = '2017-02-02'
            };
            off1.OfficialHollidayses.Add(o);
          
            Console.ReadKey();
        }
    }
}
