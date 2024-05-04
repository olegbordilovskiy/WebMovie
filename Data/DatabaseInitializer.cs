using System.Xml.Schema;
using WebMovie.Controllers;
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


				if (!context.Movies.Any())
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
							PosterImageUrl = "./img/movies/posters/reseirvoir-dogsjpg.jpg"

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
							PosterImageUrl = "./img/movies/posters/dont-breathe.jpg"

						},
						  new Movie()
						{
							EnglishTitle = "Another round",
							Description = "Four high-school teachers consume alcohol on a daily basis to see how it affects their social and professional lives.",
							StartYear = 2020,
							EndYear = 2020,
							Country = Enumerations.Country.Denmark,
							MPAA = Enumerations.MPAA.NC17,
							RuntimeMinutes = 117,
							PosterImageUrl = "./img/movies/posters/another-round.jpg"
						}
					}); 

					context.SaveChanges();
				}

				if (!context.Names.Any())
				{
					context.Names.AddRange(new List<Name>
					{
						new Name()
						{
							FullName = "Quentin Tarantino",
							BirthYear = 1963,
							DeathYear = null,
							Description =
							"Quentin Jerome Tarantino was born in Knoxville, Tennessee. His father, Tony Tarantino, is an Italian-American actor and musician from New York, " +
							"and his mother, Connie (McHugh), is a nurse from Tennessee. Quentin moved with his mother to Torrance, California, when he was four years old.\r\n\r\n" +
							"In January of 1992, first-time writer-director Tarantino's Reservoir Dogs (1992) appeared at the Sundance Film Festival. The film garnered critical acclaim " +
							"and the director became a legend immediately. Two years later, he followed up Dogs success with Pulp Fiction (1994) which premiered at the Cannes film " +
							"festival, winning the coveted Palme D'Or Award. At the 1995 Academy Awards, it was nominated for the best picture, best director and best original screenplay. " +
							"Tarantino and writing partner Roger Avary came away with the award only for best original screenplay. In 1995, Tarantino directed one fourth of the anthology Four Rooms (1995) " +
							"with friends and fellow auteurs Alexandre Rockwell, Robert Rodriguez and Allison Anders. The film opened December 25 in the United States to very weak reviews. " +
							"Tarantino's next film was From Dusk Till Dawn (1996), a vampire/crime story which he wrote and co-starred with George Clooney. The film did fairly well theatrically."
						},
						new Name()
						{
							FullName = "Martin Scorsese",
							BirthYear = 1942,
							DeathYear = null,
							Description =
							"Martin Charles Scorsese was born on November 17, 1942 in Queens, New York City, to Catherine Scorsese (née Cappa) and Charles Scorsese, who both worked in Manhattan's " +
							"garment district, and whose families both came from Palermo, Sicily. He was raised in the neighborhood of Little Italy, which later provided the inspiration for several " +
							"of his films. Scorsese earned a B.S. degree in film communications in 1964, followed by an M.A. in the same field in 1966 at New York University's School of Film"
						},
						new Name()
						{
							FullName = "Mads Mikkelsen",
							BirthYear = 1965,
							DeathYear = null,
							Description =
							"Mads Mikkelsen's great successes parallel those achieved by the Danish film industry since the mid-1990s. He was born in Østerbro, Copenhagen, to Bente Christiansen, a nurse, " +
							"and Henning Mikkelsen, a banker.Starting out as a low-life pusher/junkie in the 1996 success Pusher (1996), he slowly grew to become one of Denmark's biggest movie actors. " +
							"The success in his home country includes Blinkende lygter (2000), En kort en lang (2001) and the Emmy-winning police series Rejseholdet (2000).His success has taken him " +
							"abroad where he has played alongside Gérard Depardieu in I Am Dina (2002) as well as in the Spanish comedy Torremolinos 73 (2003) and the American blockbuster King Arthur (2004)." +
							"He played the role of Dr. Hannibal Lecter in the critically acclaimed NBC series Hannibal (2013), from 2013 to 2015, with great success."
						}
					});
					context.SaveChanges();
				}

				if (!context.Ratings.Any())
				{
					context.Ratings.AddRange(new List<Rating>
					{
						new Rating()
						{
							Movie = context.Movies.FirstOrDefault(m => m.EnglishTitle == "Reservoir Dogs"),
							VotesNumber = 1100000,
							AverageRating = 8.3m,
						},
						 new Rating()
						{
							Movie = context.Movies.FirstOrDefault(m => m.EnglishTitle == "Don't Breathe"),
							VotesNumber = 300000,
							AverageRating = 7.1m,
						},
						  new Rating()
						{
							Movie = context.Movies.FirstOrDefault(m => m.EnglishTitle == "Another round"),
							VotesNumber = 195000,
							AverageRating = 7.7m,
						}
					});

					context.SaveChanges();
				}

				//if (!context.Directors.Any())
				//{
				//	context.Directors.AddRange(new List<Director>
				//	{
				//		new Director()
				//		{
				//			Movie = context.Movies.FirstOrDefault(m => m.EnglishTitle == "Reservoir Dogs"),
				//			Name = context.Names.FirstOrDefault(n => n.FullName == "Quentin Tarantino")
				//		}
    //                    //new Director() {}
    //                });
				//	context.SaveChanges();
				//}
			}
		}
	}
}
