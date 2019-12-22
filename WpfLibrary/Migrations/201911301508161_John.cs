namespace WpfLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class John : DbMigration
    {
        public override void Up()
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
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Datebirth = c.DateTime(nullable: false),
                        Nationality = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Year = c.Int(nullable: false),
                        Ganre = c.String(),
                        Pages = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Reader_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Reader_Id)
                .Index(t => t.Reader_Id);
            
            CreateTable(
                "dbo.Chapters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Bookid = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        Name = c.String(),
                        StartPage = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Bookid, cascadeDelete: true)
                .Index(t => t.Bookid);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Phone = c.Int(nullable: false),
                        Login = c.String(),
                        Password = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReaderCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Idbook = c.Int(nullable: false),
                        Idreader = c.Int(nullable: false),
                        Date1 = c.DateTime(nullable: false),
                        Reader_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Reader_Id)
                .Index(t => t.Reader_Id);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReaderCards", "Reader_Id", "dbo.People");
            DropForeignKey("dbo.Books", "Reader_Id", "dbo.People");
            DropForeignKey("dbo.Chapters", "Bookid", "dbo.Books");
            DropForeignKey("dbo.BookAuthors", "Author_Id", "dbo.Authors");
            DropForeignKey("dbo.BookAuthors", "Book_Id", "dbo.Books");
            DropIndex("dbo.BookAuthors", new[] { "Author_Id" });
            DropIndex("dbo.BookAuthors", new[] { "Book_Id" });
            DropIndex("dbo.ReaderCards", new[] { "Reader_Id" });
            DropIndex("dbo.Chapters", new[] { "Bookid" });
            DropIndex("dbo.Books", new[] { "Reader_Id" });
            DropTable("dbo.BookAuthors");
            DropTable("dbo.ReaderCards");
            DropTable("dbo.People");
            DropTable("dbo.Chapters");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
            DropTable("dbo.AuthorBooks");
        }
    }
}
