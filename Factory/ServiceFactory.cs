using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Factory;

public interface IServiceFactory<TService>
{
    TService Service { get; }
}

public class ServiceFactory<TService> : IServiceFactory<TService>
{
    // IServiceFactory<TService> that can resolve the TService from the DI container or creates an instance if it's not in the container:
    public ServiceFactory(IServiceProvider service)
    {
        Service = (TService)service.GetService(typeof(TService)) ?? ActivatorUtilities.CreateInstance<TService>(service);
    }

    public TService Service { get; }


    // Configure like this in Startup.cs
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient(typeof(IServiceFactory<>), typeof(ServiceFactory<>));
    }
}

