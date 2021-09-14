namespace Docitcare_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Password_Column_UltraUserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UltraUsers", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UltraUsers", "Password");
        }
    }
}
