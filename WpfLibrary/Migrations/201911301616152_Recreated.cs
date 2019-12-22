namespace WpfLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Recreated : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookAuthors", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.BookAuthors", "Author_Id", "dbo.Authors");
            DropIndex("dbo.BookAuthors", new[] { "Book_Id" });
            DropIndex("dbo.BookAuthors", new[] { "Author_Id" });
            DropTable("dbo.BookAuthors");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.BookAuthors",
                c => new
                    {
                        Book_Id = c.Int(nullable: false),
                        Author_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Book_Id, t.Author_Id });
            
            CreateIndex("dbo.BookAuthors", "Author_Id");
            CreateIndex("dbo.BookAuthors", "Book_Id");
            AddForeignKey("dbo.BookAuthors", "Author_Id", "dbo.Authors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.BookAuthors", "Book_Id", "dbo.Books", "Id", cascadeDelete: true);
        }
    }
}
