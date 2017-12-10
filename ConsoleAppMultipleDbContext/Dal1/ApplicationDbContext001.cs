using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppMultipleDbContext.Dal1.Classes;
namespace ConsoleAppMultipleDbContext.Dal1
{
    public class ApplicationDbContext001: DbContext
    {
        public ApplicationDbContext001() : base("DbTest001")
        { }

        public DbSet<Employee> Employees { get; set; }
    }
}
