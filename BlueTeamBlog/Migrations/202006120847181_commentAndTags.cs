namespace BlueTeamBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class commentAndTags : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Tag_Id", c => c.Int());
            AddColumn("dbo.Comments", "Body", c => c.String());
            AddColumn("dbo.Comments", "Created", c => c.DateTime(nullable: false));
            AddColumn("dbo.Comments", "Post_Id", c => c.Int());
            AddColumn("dbo.Comments", "User_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Tags", "TagName", c => c.String());
            CreateIndex("dbo.Posts", "Tag_Id");
            CreateIndex("dbo.Comments", "Post_Id");
            CreateIndex("dbo.Comments", "User_Id");
            AddForeignKey("dbo.Comments", "Post_Id", "dbo.Posts", "Id");
            AddForeignKey("dbo.Comments", "User_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Posts", "Tag_Id", "dbo.Tags", "Id");
            DropColumn("dbo.Comments", "Rami");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "Rami", c => c.String());
            DropForeignKey("dbo.Posts", "Tag_Id", "dbo.Tags");
            DropForeignKey("dbo.Comments", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Comments", "Post_Id", "dbo.Posts");
            DropIndex("dbo.Comments", new[] { "User_Id" });
            DropIndex("dbo.Comments", new[] { "Post_Id" });
            DropIndex("dbo.Posts", new[] { "Tag_Id" });
            DropColumn("dbo.Tags", "TagName");
            DropColumn("dbo.Comments", "User_Id");
            DropColumn("dbo.Comments", "Post_Id");
            DropColumn("dbo.Comments", "Created");
            DropColumn("dbo.Comments", "Body");
            DropColumn("dbo.Posts", "Tag_Id");
        }
    }
}
