using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace FinalChallengeAssignment
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
