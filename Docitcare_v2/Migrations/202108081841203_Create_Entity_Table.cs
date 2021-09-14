namespace Docitcare_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Entity_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entities",
                c => new
                    {
                        EntityId = c.Int(nullable: false, identity: true),
                        HospitalName = c.String(nullable: false),
                        HolderFirstName = c.String(nullable: false),
                        HolderLastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        HospitalContactNumber1 = c.String(nullable: false),
                        HospitalContactNumber2 = c.String(),
                        ContactPersonName = c.String(nullable: false),
                        ContactPhoneNumberName = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        EstablishedYear = c.Int(nullable: false),
                        RegisteredDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EntityId);
            
            CreateTable(
                "dbo.EntityBranches",
                c => new
                    {
                        BranchId = c.Int(nullable: false, identity: true),
                        BranchName = c.String(),
                        EntityID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BranchId)
                .ForeignKey("dbo.Entities", t => t.EntityID, cascadeDelete: true)
                .Index(t => t.EntityID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EntityBranches", "EntityID", "dbo.Entities");
            DropIndex("dbo.EntityBranches", new[] { "EntityID" });
            DropTable("dbo.EntityBranches");
            DropTable("dbo.Entities");
        }
    }
}
