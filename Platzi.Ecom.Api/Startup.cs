using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Platzi.Ecom.Core.Common;
using Platzi.Ecom.Core.Customers;
using Platzi.Ecom.Data;

namespace Platzi.Ecom.Api
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // Configure dependency injection!
            services.Add(new ServiceDescriptor(typeof(ICustomerService), typeof(CustomerService), ServiceLifetime.Scoped));    // Scoped
            services.Add(new ServiceDescriptor(typeof(ICustomerRepository), typeof(CustomerRepository), ServiceLifetime.Scoped));    // Scoped
            services.Add(new ServiceDescriptor(typeof(IRepositoryBase<>), typeof(RepositoryBase<>), ServiceLifetime.Scoped));    // Scoped

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
