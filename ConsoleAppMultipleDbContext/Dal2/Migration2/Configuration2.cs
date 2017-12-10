namespace ConsoleAppMultipleDbContext.Dal2.Migration2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration2 : DbMigrationsConfiguration<ConsoleAppMultipleDbContext.Dal2.ApplicationDbContext002>
    {
        public Configuration2()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Dal2\Migration2";
        }

        protected override void Seed(ConsoleAppMultipleDbContext.Dal2.ApplicationDbContext002 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
