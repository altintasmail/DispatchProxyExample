using DispatchProxyTest.CrossCuttingConcerns;
using DispatchProxyTest.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DispatchProxyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
            .AddTransient<ILogService, LogService>()
            .AddTransient<ICacheService, CacheService>()
            .AddTransient<IValidationService, ValidationService>()
            .AddTransient<ISomeService, SomeService>()
            .AddTransient<IMoreService, MoreService>()
            .DecorateWithDispatchProxy<ISomeService, DispatchProxy<ISomeService>>()
            .DecorateWithDispatchProxy<IMoreService, DispatchProxy<IMoreService>>()
            .BuildServiceProvider();

            var service1 = serviceProvider.GetRequiredService<ISomeService>();
            var service2 = serviceProvider.GetRequiredService<IMoreService>();
            service1.Do("Hello World");
            service2.DoMore("Hello Space");
            Console.ReadLine();
        }
    }
}
