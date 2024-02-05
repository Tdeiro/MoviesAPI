using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Movies.Any()) return;

            var movies = new List<Movie>
            {
                new Movie
                {
                    Title = "Test",
                    Rating = "10",
                    MovieId = "123",
                    Review = "badbadbad",
                    Category = "action",
                    UserId = "222",
                },
                new Movie
                {
                    Title = "Test 2",
                    Rating = "8",
                    MovieId = "12345",
                    Review = "badbadbad",
                    Category = "action",
                    UserId = "222",
                },
            };

            await context.Movies.AddRangeAsync(movies);
            await context.SaveChangesAsync();
        }
    }
}