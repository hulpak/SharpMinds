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
             
            var arr = off.Context.Users.ToList();
            foreach (var i in arr)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4},{5},{6}  ", i.Id, i.FullName, i.Email, i.Password, i.StartDate,i.StatusId,i.LevelId);
            }
            Console.ReadKey();
        }
    }
}
