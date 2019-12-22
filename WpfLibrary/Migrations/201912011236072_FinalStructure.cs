namespace WpfLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinalStructure : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ReaderCards", "Idreader");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ReaderCards", "Idreader", c => c.Int(nullable: false));
        }
    }
}
