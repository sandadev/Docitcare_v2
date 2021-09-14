namespace Docitcare_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_UltraRoleMapping_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UltraRoleMappings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UltraUserId = c.Int(nullable: false),
                        UltraRoleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UltraRoles", t => t.UltraRoleID, cascadeDelete: true)
                .ForeignKey("dbo.UltraUsers", t => t.UltraUserId, cascadeDelete: true)
                .Index(t => t.UltraUserId)
                .Index(t => t.UltraRoleID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UltraRoleMappings", "UltraUserId", "dbo.UltraUsers");
            DropForeignKey("dbo.UltraRoleMappings", "UltraRoleID", "dbo.UltraRoles");
            DropIndex("dbo.UltraRoleMappings", new[] { "UltraRoleID" });
            DropIndex("dbo.UltraRoleMappings", new[] { "UltraUserId" });
            DropTable("dbo.UltraRoleMappings");
        }
    }
}
