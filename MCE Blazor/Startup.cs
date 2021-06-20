using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading.Tasks;
using ElectronNET.API;
using ElectronNET.API.Entities;
using MCE.Model;
using MCE_Blazor.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Syncfusion.Blazor;
using Syncfusion.Licensing;

namespace MCE
{
    [SuppressMessage("ReSharper", "CA1822")]
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddElectron();
            services.AddSingleton<ISeeder, Seeder>();
            services.AddDbContextFactory<MidgardContext>(opt =>
                opt.UseSqlite($"Data Source={Path.Combine(Environment.CurrentDirectory, "m5editor.db")}"));

            services.AddScoped(p =>
                p.GetRequiredService<IDbContextFactory<MidgardContext>>()
                 .CreateDbContext());
            services.AddSyncfusionBlazor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            SyncfusionLicenseProvider.RegisterLicense("NDYxMzUwQDMxMzkyZTMxMmUzMFJTV1VDOTlJUnd4V3NjU3NKM055OUthQXM4SWthTDlIUFJCVUFPTGc1d2c9");
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });

            if (HybridSupport.IsElectronActive)
            {
                ElectronBootstrap();
            }
        }

        private async void ElectronBootstrap()
        {
            var browserWindow = await Electron.WindowManager.CreateWindowAsync(new BrowserWindowOptions
            {
                Width  = 1152,
                Height = 940,
                Show   = false
            });
            await browserWindow.WebContents.Session.ClearCacheAsync();
            browserWindow.OnReadyToShow += () => browserWindow.Show();
            browserWindow.SetTitle("Midgard Charakter Editor");
            browserWindow.RemoveMenu();
        }
    }
}