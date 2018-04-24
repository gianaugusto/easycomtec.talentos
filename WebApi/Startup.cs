using Database;
using Database.Interfaces;
using Database.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using AutoMapper;
using WebApi.Map;
using FluentValidation.AspNetCore;
using WebApi.Filters;

namespace WebApi
{
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
            services.AddCors(o => o.AddPolicy("AllowAll", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(ValidateModel));
            })
                    .AddFluentValidation(fvc =>
                        fvc.RegisterValidatorsFromAssemblyContaining<Startup>());
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "API Talentos Easycom",
                    Description = "API para gerenciamento e manutencao de talentos da Easycom",
                    TermsOfService = "None",
                    Contact = new Contact() { Name = "Giancarlos A. Macedo", Email = "gianaugusto@gmail.com", Url = "www.gianaugusto.com.br" }
                });
            });

            MapperInitializer.Init();

            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<AutoMapper.IConfigurationProvider>(), sp.GetService));
            services.AddScoped<DbContext, Context>();

            var connString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<Context>(o => o.UseSqlServer(connString));
            services.AddScoped<ITalentoRepository, TalentoRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable Cors
            app.UseCors("AllowAll");


            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Talentos easycom V1");
            });

            app.UseCors(c =>
            {
                c.AllowAnyHeader();
                c.AllowAnyMethod();
                c.AllowAnyOrigin();
            });

            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<Context>();

                if(context.Database.EnsureCreated())
                {
                    var seed = new Database.Tools.Seed(context);

                    // preenche os dados iniciais
                    seed.ConhecimentoInicial();

                    // preenche os dados iniciais
                    seed.UsuarioInicial();

                }
            }

        }

    }
}
