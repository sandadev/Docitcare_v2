namespace Docitcare_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Entity_Table_MobileNumber_Added : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EntityBranches", "EntityID", "dbo.Entities");
            DropIndex("dbo.EntityBranches", new[] { "EntityID" });
            AddColumn("dbo.Entities", "ContactPersonPhoneNumber", c => c.Long(nullable: false));
            AddColumn("dbo.Entities", "MobileNumber", c => c.Long(nullable: false));
            AlterColumn("dbo.Entities", "HospitalContactNumber1", c => c.Long(nullable: false));
            AlterColumn("dbo.Entities", "HospitalContactNumber2", c => c.Long(nullable: false));
            DropColumn("dbo.Entities", "ContactPhoneNumberName");
            DropTable("dbo.EntityBranches");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EntityBranches",
                c => new
                    {
                        BranchId = c.Int(nullable: false, identity: true),
                        BranchName = c.String(),
                        EntityID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BranchId);
            
            AddColumn("dbo.Entities", "ContactPhoneNumberName", c => c.String(nullable: false));
            AlterColumn("dbo.Entities", "HospitalContactNumber2", c => c.String());
            AlterColumn("dbo.Entities", "HospitalContactNumber1", c => c.String(nullable: false));
            DropColumn("dbo.Entities", "MobileNumber");
            DropColumn("dbo.Entities", "ContactPersonPhoneNumber");
            CreateIndex("dbo.EntityBranches", "EntityID");
            AddForeignKey("dbo.EntityBranches", "EntityID", "dbo.Entities", "EntityId", cascadeDelete: true);
        }
    }
}
