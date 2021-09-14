namespace Docitcare_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Arole_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UltraRoles",
                c => new
                    {
                        UltraRoleID = c.Int(nullable: false, identity: true),
                        UltraRoleName = c.String(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.UltraRoleID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UltraRoles");
        }
    }
}
