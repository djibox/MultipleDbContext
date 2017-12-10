using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleAppMultipleDbContext.Dal2.Classes;

namespace ConsoleAppMultipleDbContext.Dal2
{
    public class ApplicationDbContext002:DbContext
    {
        public ApplicationDbContext002():base("DbTest001")
        { }

        public DbSet<Matiere> Matieres { get; set; }
    }
}
