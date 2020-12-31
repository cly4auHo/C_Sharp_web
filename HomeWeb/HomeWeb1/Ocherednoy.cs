using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HomeWeb1
{
    public class Ocherednoy
    {
        private const string outKey = "Logging";
        private const string firstKey = "LogLevel";
        private const string innerKey = "Microsoft.Hosting.Lifetime";

        private IConfiguration configuration { get; set; }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    string answer = configuration.GetValue<string>(outKey + ":" + firstKey + ":" + innerKey);
                    await context.Response.WriteAsync(answer);
                });
            });
        }

        public Ocherednoy(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
    }
}
