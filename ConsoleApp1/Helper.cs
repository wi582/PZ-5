using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Helper
    {
        private static Shoe_FactoryEntities _context;
        public static Shoe_FactoryEntities GetContext()
        {
            if (_context == null)
            {
                _context = new Shoe_FactoryEntities();
            }
            return _context;
        }
        public static List<T> GetAll<T>() where T : class
        {
            return GetContext().Set<T>().ToList();
        }

        public static void Create<T>(T item) where T : class
        {
            GetContext().Set<T>().Add(item);
            GetContext().SaveChanges();
        }

        public static void Update<T>(T item) where T : class
        {
            GetContext().Entry(item).State = EntityState.Modified;
            GetContext().SaveChanges();
        }

        public static void Remove<T>(T item) where T : class
        {
            GetContext().Set<T>().Remove(item);
            GetContext().SaveChanges();
        }
    }
}