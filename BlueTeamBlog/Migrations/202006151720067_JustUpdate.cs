namespace BlueTeamBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JustUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blogs", "Title", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Blogs", "Title", c => c.String());
        }
    }
}
