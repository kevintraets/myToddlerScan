using System;
using System.Linq;
using ToddlerScan.Data;
using ToddlerScan.Domain;

namespace SomeUIForData
{
    class Program
    {
        static void Main(string[] args)
        {
            //insertNewToddler();
            //insertNewTeacher();
            showAllToddlers();
        }

        //Just to see if DB works
        private static void insertNewToddler()
        {
            var toddler = new Toddler
            {
                FirstName = "Anneleen",
                Grade = "2",
                LastName = "Poncelet"
            };
            using (var context = new ToddlerScanContext())
            {
                context.Toddlers.Add(toddler);
                context.SaveChanges();
            }
        }

        private static void insertNewTeacher()
        {
            var teacher = new Teacher
            {
                FirstName = "Lowie",
                LastName = "Vangaal"
            };
            using (var context = new ToddlerScanContext())
            {
                context.Teachers.Add(teacher);
                context.SaveChanges();
            }
        }

        private static void showAllToddlers()
        {
            using (var context = new ToddlerScanContext())
            {
                var toddlers = context.Toddlers.ToList();
                foreach (var toddler in toddlers)
                {
                    Console.WriteLine(toddler.FirstName + " ");
                }

                Console.ReadLine();
            }
        }
    }
}
