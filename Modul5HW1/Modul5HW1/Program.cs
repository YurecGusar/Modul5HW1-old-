using System;
using Microsoft.Extensions.DependencyInjection;

namespace Modul5HW1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<Starter>()
                .BuildServiceProvider();

            var starter = serviceProvider.GetService<Starter>();
            starter.Run();
        }
    }
}
