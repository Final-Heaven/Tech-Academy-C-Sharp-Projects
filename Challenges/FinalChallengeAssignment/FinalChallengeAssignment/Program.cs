using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FinalChallengeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.WriteLine("Enter the new student's first name: ");
                var fName = Console.ReadLine();

                Console.WriteLine("Enter the new student's last name: ");
                var lName = Console.ReadLine();

                var student = new Student { FirstName = fName, LastName = lName };
                db.Students.Add(student);
                db.SaveChanges();

                var query = from b in db.Students
                            select b;

                Console.WriteLine("All students in the database: ");
                foreach (var item in query)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName);
                }

                Console.ReadLine();
            }
        }
    }
}
