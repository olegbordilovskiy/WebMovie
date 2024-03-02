using System.Xml.Schema;
using WebMovie.Models;

namespace WebMovie.Data
{
    public class DatabaseInitializer
    {
        public static void Seed(IApplicationBuilder appBuilder)
        {
            using (var serviceScope = appBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<DatabaseContext>();

                context.Database.EnsureCreated();


                if (context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>
                    {
                        new Movie()
                        {
                            EnglishTitle = "Reservoir Dogs",
                            Description = "When a simple jewelry heist goes horribly wrong, the surviving criminals begin to suspect that one of them is a police informant.",
                            StartYear = 1992,
                            EndYear = 1992,
                            Country = Enumerations.Country.United_States,
                            MPAA = Enumerations.MPAA.R,
                            RuntimeMinutes = 99,
                            PosterImageUrl = "\\..\\wwwroot\\img\\movies\\posters\\reseirvoir-dogsjpg.jpg"

						},
                         new Movie()
                        {
                            EnglishTitle = "Don't Breathe",
                            Description = "Hoping to walk away with a massive fortune, a trio of thieves break into the house of a blind man who isn't as helpless as he seems.",
                            StartYear = 2016,
                            EndYear = 2016,
                            Country = Enumerations.Country.United_States,
							MPAA = Enumerations.MPAA.R,
							RuntimeMinutes = 88,
                            PosterImageUrl = "\\..\\wwwroot\\img\\movies\\posters\\dont-breathe.jpg"

						}
                    });;

                    context.SaveChanges();
                }

            }
        }
    }
}
