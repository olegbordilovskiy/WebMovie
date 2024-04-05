using Microsoft.EntityFrameworkCore;
using WebMovie.Data;
using WebMovie.Services;
using WebMovie.Services.Interfaces;

namespace WebMovie
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IMoviesService, MoviesService>();
			builder.Services.AddScoped<IRatingsService, RatingsService>();
			builder.Services.AddScoped<IDirectorsService, DirectorsService>();
			builder.Services.AddScoped<IRolesService, RolesService>();

			var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Movies}/{action=Index}/{id?}");

            DatabaseInitializer.Seed(app);
            app.Run();

            //
        }
    }
}
