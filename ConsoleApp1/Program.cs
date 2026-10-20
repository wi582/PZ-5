using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shoes = Helper.GetAll<Shoes>();
            Console.WriteLine("Записей в таблице Shoes: " + shoes.Count);

            var employees = Helper.GetAll<Employees>();
            Console.WriteLine("Записей в таблице Employees: " + employees.Count);

            Console.ReadKey();
        }
    }
}
