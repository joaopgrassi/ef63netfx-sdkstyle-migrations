using EFDemo.Data.Entities;
using System.Data.Entity.Migrations;

namespace EFDemo.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EFDemo.Data.MoviesDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFDemo.Data.MoviesDbContext context)
        {
            context.Movies.AddOrUpdate(m => m.Id,
                new Movie { Id = 1, Title = "Avengers: Endgame" },
                new Movie { Id = 2, Title = "Forrest Gump" },
                new Movie { Id = 3, Title = "Schindler's List" }
            );
        }
    }
}
