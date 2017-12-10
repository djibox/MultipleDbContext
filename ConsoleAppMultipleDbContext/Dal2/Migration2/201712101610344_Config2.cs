namespace ConsoleAppMultipleDbContext.Dal2.Migration2
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Config2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matieres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Matieres");
        }
    }
}
