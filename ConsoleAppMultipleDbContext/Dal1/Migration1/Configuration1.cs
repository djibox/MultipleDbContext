namespace ConsoleAppMultipleDbContext.Dal1.Migration1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration1 : DbMigrationsConfiguration<ConsoleAppMultipleDbContext.Dal1.ApplicationDbContext001>
    {
        public Configuration1()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Dal1\Migration1";
        }

        protected override void Seed(ConsoleAppMultipleDbContext.Dal1.ApplicationDbContext001 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
