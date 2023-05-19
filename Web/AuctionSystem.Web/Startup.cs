﻿namespace AuctionSystem.Web
{
    using System;
    using AuctionSystem.Models;
    using AutoMapper;
    using Common.AutoMapping.Profiles;
    using Data;
    using Infrastructure.Extensions;
    using Infrastructure.Utilities;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.UI;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Routing;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Services.Models;
    using SignalRHubs;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .Configure<CloudinaryOptions>(options =>
                {
                    options.CloudName = this.Configuration.GetSection("Cloudinary:CloudName").Value;
                    options.ApiKey = this.Configuration.GetSection("Cloudinary:ApiKey").Value;
                    options.ApiSecret = this.Configuration.GetSection("Cloudinary:ApiSecret").Value;
                })
                .Configure<SendGridOptions>(options =>
                {
                    options.SendGridApiKey = this.Configuration.GetSection("SendGrid:ApiKey").Value;
                })
                .Configure<CookiePolicyOptions>(options =>
                {
                    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                    options.CheckConsentNeeded = context => true;
                    options.MinimumSameSitePolicy = SameSiteMode.None;
                });

            services
                .Configure<CookieTempDataProviderOptions>(options => { options.Cookie.IsEssential = true; });

            services.AddDbContext<AuctionSystemDbContext>(options =>
                options.UseSqlServer(this.Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<AuctionUser, IdentityRole>(options =>
                {
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                })
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<AuctionSystemDbContext>()
                .AddDefaultTokenProviders();

            services
                .AddDomainServices()
                .AddApplicationServices()
                .AddAuthentication();

            services.Configure<SecurityStampValidatorOptions>(options =>
            {
                options.ValidationInterval = TimeSpan.Zero;
            });

            services
                .Configure<RouteOptions>(options => options.LowercaseUrls = true);

            services
                .AddSignalR();

            services
                .AddResponseCompression(options => options.EnableForHttps = true);

            services
                .AddMvc(options => { options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>(); })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            Mapper.Initialize(config => config.AddProfile<DefaultProfile>());

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseResponseCompression();
            app.UseStatusCodePages();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseSignalR(config=> config.MapHub<BidHub>("/bidHub"));

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "items",
                    template: "Items/Details/{id}/{slug:required}",
                    defaults: new { controller = "Items", action = "Details" });
            });

            app.SeedData();
        }
    }
}