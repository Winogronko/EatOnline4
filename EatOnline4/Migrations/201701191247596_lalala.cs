namespace EatOnline4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lalala : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "AuthSecurity", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "AuthSecurity");
        }
    }
}
