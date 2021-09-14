namespace Docitcare_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_UltraUser_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UltraUsers",
                c => new
                    {
                        UltraUserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        MobileNumber = c.Long(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.UltraUserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UltraUsers");
        }
    }
}
