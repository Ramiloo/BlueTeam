namespace BlueTeamBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class postupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Title", c => c.String(nullable: false, maxLength: 250));
            AddColumn("dbo.Posts", "Content", c => c.String(nullable: false));
            AddColumn("dbo.Posts", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Posts", "Tags", c => c.String(nullable: false, maxLength: 1000));
            AddColumn("dbo.Posts", "BlogId", c => c.Int(nullable: false));
            CreateIndex("dbo.Posts", "BlogId");
            AddForeignKey("dbo.Posts", "BlogId", "dbo.Blogs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "BlogId", "dbo.Blogs");
            DropIndex("dbo.Posts", new[] { "BlogId" });
            DropColumn("dbo.Posts", "BlogId");
            DropColumn("dbo.Posts", "Tags");
            DropColumn("dbo.Posts", "CreatedOn");
            DropColumn("dbo.Posts", "Content");
            DropColumn("dbo.Posts", "Title");
        }
    }
}
