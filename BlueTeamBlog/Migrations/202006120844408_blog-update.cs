namespace BlueTeamBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blogupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Title", c => c.String());
            AddColumn("dbo.Blogs", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Blogs", "AuthorId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Blogs", "AuthorId");
            AddForeignKey("dbo.Blogs", "AuthorId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blogs", "AuthorId", "dbo.AspNetUsers");
            DropIndex("dbo.Blogs", new[] { "AuthorId" });
            DropColumn("dbo.Blogs", "AuthorId");
            DropColumn("dbo.Blogs", "CreatedOn");
            DropColumn("dbo.Blogs", "Title");
        }
    }
}
