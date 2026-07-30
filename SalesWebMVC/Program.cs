using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Service;
using SalesWebMVC.Services;


namespace SalesWebMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("SalesWebMVCContext") ?? throw new InvalidOperationException("Connection string 'SalesWebMVCContext' not found.");

            builder.Services.AddDbContext<SalesWebMVCContext>(options =>    options.UseSqlServer(connectionString));
            //builder.Services.AddDbContext<SalesWebMVCContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            
            // Registro dos serviços
            builder.Services.AddScoped<SeedingService>();
            builder.Services.AddScoped<SellerService>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //cria o app
            var app = builder.Build();

            // ===== EXECUTA O SEEDING =====
            using (var scope = app.Services.CreateScope())
            {
                var seedingService = scope.ServiceProvider.GetRequiredService<SeedingService>();
                seedingService.Seed();
            }
            

            

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
