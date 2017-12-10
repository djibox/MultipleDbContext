using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppMultipleDbContext.Dal1;
using ConsoleAppMultipleDbContext.Dal1.Classes;
using ConsoleAppMultipleDbContext.Dal2;
using ConsoleAppMultipleDbContext.Dal2.Classes;

namespace ConsoleAppMultipleDbContext
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (ApplicationDbContext001 db = new ApplicationDbContext001())
            //{
            //    Employee emp = new Employee
            //    {
            //        FullName = "Leger DJIBA",
            //        Address = "Riviera 3"
            //    };
            //    db.Employees.Add(emp);
            //    db.SaveChanges();
            //    Console.WriteLine($"employee avec les informations suivantes a été crée avec succés : FullName : {emp.FullName}");
            //}

            //using (ApplicationDbContext002 db = new ApplicationDbContext002())
            //{
            //    Matiere mapMatiere = new Matiere
            //    {
            //        Name = "Leger DJIBA"
            //    };
            //    db.Matieres.Add(mapMatiere);
            //    db.SaveChanges();
            //    Console.WriteLine($"La matiere avec les informations suivantes a été crée avec succés : Name : {mapMatiere.Name}");
            //}

            using (ApplicationDbContext001 db = new ApplicationDbContext001())
            {
                foreach (var variable in db.Employees)
                {
                    Console.WriteLine($"FullName : {variable.FullName} and Address : {variable.Address}");
                }

            }

            using (ApplicationDbContext002 db = new ApplicationDbContext002())
            {
                foreach (var variable in db.Matieres)
                {
                    Console.WriteLine($"FullName : {variable.Name}");
                }

            }
        }
    }
}
