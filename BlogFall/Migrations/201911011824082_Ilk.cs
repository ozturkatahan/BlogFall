namespace BlogFall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AuthorId = c.String(nullable: false, maxLength: 128),
                        CategoryId = c.String(nullable: false),
                        Title = c.String(nullable: false, maxLength: 200),
                        Content = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.AuthorId)
                .Index(t => t.Category_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Posts", "AuthorId", "dbo.AspNetUsers");
            DropIndex("dbo.Posts", new[] { "Category_Id" });
            DropIndex("dbo.Posts", new[] { "AuthorId" });
            DropTable("dbo.Posts");
            DropTable("dbo.Categories");
        }
    }
}
