
using AutoMapper;
using BusinessLayer;
using BusinessLayer.ScheduleRequest;
using BusinessLayer.ScheduleRequest.Abstract;
using BusinessLayer.ScheduleRequest.Validator;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PersistanceLayer;

namespace FlexiBackEnd
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
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddSingleton<IScheduleRequestPersister, RequestContainer>();
            services.AddSingleton<ISupervisorEmailSenderHandler, SupervisorEmailSenderCommandHandler>();
            services.AddSingleton<IValidate, ValidateData>();
            services.AddSingleton<IScheduleRequestAdder, ScheduleRequestAdder>();
            services.AddSingleton<IScheduleLimitsQueryHandler, ScheduleLimitsQueryHandler>();
            services.AddSingleton<ICurrentUserIdQueryHandler, CurrentUserQueryHandler>();
            services.AddSingleton<ISupervisorListQueryHandler, SupervisorQueryHandler>();
            services.AddControllers();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors("MyPolicy");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
