namespace CleanCoding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ArticleID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.ArticleID);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        ArticleID = c.Int(nullable: false),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Articles", t => t.ArticleID, cascadeDelete: true)
                .Index(t => t.ArticleID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Comments", new[] { "ArticleID" });
            DropForeignKey("dbo.Comments", "ArticleID", "dbo.Articles");
            DropTable("dbo.Comments");
            DropTable("dbo.Articles");
        }
    }
}
