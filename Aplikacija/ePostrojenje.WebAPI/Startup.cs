using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ePostrojenje.Model.Requests;
using ePostrojenje.WebAPI.Database;
using ePostrojenje.WebAPI.Filters;
using ePostrojenje.WebAPI.Security;
using ePostrojenje.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Configuration;

namespace ePostrojenje.WebAPI
{
    public class BasicAuthDocumentFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            var securityRequirements = new Dictionary<string, IEnumerable<string>>()
        {
            { "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
        };

            swaggerDoc.Security = new[] { securityRequirements };
        }
    }

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("basic", new BasicAuthScheme() { Type = "basic" });
                c.DocumentFilter<BasicAuthDocumentFilter>();
            });

            services.AddAuthentication("BasicAuthentication")
               .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddScoped<IOsobljeService, OsobljeService>();
            services.AddScoped<IReklamacijeService, ReklamacijeService>();
            services.AddScoped<IKupciService, KupacService>();
            services.AddScoped<IObavjestenjaService, ObavjestenjaService>();
            services.AddScoped<IRSII25092020Service, RSII25092020Service>();

            //services.AddScoped<IService<Model.Kupci, object>, BaseService<Model.Kupci, object, Kupci>>();

            services.AddScoped<IService<Model.Odjeli, object>, BaseService<Model.Odjeli, object, Odjeli>>();

            services.AddScoped<IService<Model.TarifniStavovi, object>, BaseService<Model.TarifniStavovi, object, TarifniStavovi>>();

            services.AddScoped<ICRUDService<Model.Racuni, RacuniSearchRequest, RacuniInsertRequest, RacuniInsertRequest>, RacuniService>();
            services.AddScoped<ICRUDService<Model.VrstaAplikacije, Model.VrstaAplikacije, VrstaAplikacijeInsert, VrstaAplikacijeInsert>, VrstaAplikacijeService>();
            services.AddScoped<ICRUDService<Model.Ugovori, Model.Ugovori, UgovoriUpdateRequest, UgovoriUpdateRequest>, UgovoriService>();
            services.AddScoped<ICRUDService<Model.Ocjene, Model.Ocjene, OcjeneUpdateRequest, OcjeneUpdateRequest>, OcjeneService>();


            //services.AddScoped<ICRUDService<Model.Reklamacije, ReklamacijeSearchRequest, ReklamacijeInsertRequest, ReklamacijeInsertRequest>, ReklamacijeService>();

            //var connection = @"Server=.;Database=150217;Trusted_Connection=True;ConnectRetryCount=0";

            //string connStr = Configuration.GetConnectionString("BloggingDatabase")

            services.AddDbContext<_150217Context>(options => options.UseSqlServer(Configuration.GetConnectionString("150217")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseAuthentication();

            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
