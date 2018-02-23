namespace bit285_multiple_entities_demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class moreupdates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "BookID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "BookID");
        }
    }
}
