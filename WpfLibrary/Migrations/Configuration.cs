namespace WpfLibrary.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WpfLibrary.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<WpfLibrary.Models.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "WpfLibrary.Models.LibraryContext";
        }

        protected override void Seed(WpfLibrary.Models.LibraryContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            
        }
    }
}
