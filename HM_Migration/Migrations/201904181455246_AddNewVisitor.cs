namespace HM_Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewVisitor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Visitors",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DateJoin = c.DateTime(nullable: false),
                        DateLeave = c.DateTime(nullable: false),
                        Name = c.String(),
                        DocumentNumber = c.String(),
                        VisitPurpose = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Visitors");
        }
    }
}
