namespace WpfLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Recreated2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookAuthors",
                c => new
                    {
                        Book_Id = c.Int(nullable: false),
                        Author_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Book_Id, t.Author_Id })
                .ForeignKey("dbo.Books", t => t.Book_Id, cascadeDelete: true)
                .ForeignKey("dbo.Authors", t => t.Author_Id, cascadeDelete: true)
                .Index(t => t.Book_Id)
                .Index(t => t.Author_Id);
            
            AddColumn("dbo.ReaderCards", "DateTaken", c => c.DateTime(nullable: false));
            DropColumn("dbo.ReaderCards", "Date1");
            DropTable("dbo.AuthorBooks");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AuthorBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdAuthor = c.Int(nullable: false),
                        IdBook = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ReaderCards", "Date1", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.BookAuthors", "Author_Id", "dbo.Authors");
            DropForeignKey("dbo.BookAuthors", "Book_Id", "dbo.Books");
            DropIndex("dbo.BookAuthors", new[] { "Author_Id" });
            DropIndex("dbo.BookAuthors", new[] { "Book_Id" });
            DropColumn("dbo.ReaderCards", "DateTaken");
            DropTable("dbo.BookAuthors");
        }
    }
}
