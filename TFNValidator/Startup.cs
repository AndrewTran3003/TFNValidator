using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using TFNValidator.Data;
using TFNValidator.Repositories.Abstract;
using TFNValidator.Services.Abstract;
using TFNValidator.Services.Concrete;

namespace TFNValidator
{
    public class Startup
    {
        #region Public Properties

        public IConfiguration Configuration { get; }

        #endregion Public Properties

        #region Public Constructors

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        #endregion Public Constructors

        #region Public Methods

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TFNValidator v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICommonTfnValidator, CommonTfnValidator>();
            services.AddScoped<IEightDigiValidator, EightDigitValidator>();
            services.AddScoped<INineDigitTfnValidator, NineDigitTfnValidator>();
            services.AddScoped<ITfnValidatorFactory, TfnValidatorFactory>();
            services.AddScoped<ILinkedValueValidator, LinkedValueValidator>();
            services.AddScoped<ITfnService, TfnService>();
            services.AddScoped<IRequestEntriesRepository, IRequestEntriesRepository>();
            services.AddDbContext<RequestEntriesContext>(options => { options.UseSqlServer(Configuration.GetConnectionString("RequestEntriesDatabase")); });
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "TFNValidator",
                    Version = "v1"
                });
            });
        }

        #endregion Public Methods
    }
}