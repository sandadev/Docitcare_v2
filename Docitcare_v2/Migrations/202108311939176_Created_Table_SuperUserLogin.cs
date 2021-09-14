namespace Docitcare_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Created_Table_SuperUserLogin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SuperUserLogins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        MobileNumber = c.Long(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SuperUserLogins");
        }
    }
}
