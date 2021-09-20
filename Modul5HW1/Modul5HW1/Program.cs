using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Modul5HW1.Services;
using Modul5HW1.Services.Abstractions;

namespace Modul5HW1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<Startup>()
                .AddTransient<IMyHttpMethodsService, MyHttpMethodsService>()
                .AddTransient<IUsersClientService, UsersClientService>()
                .BuildServiceProvider();

            var sturtup = serviceProvider.GetService<Startup>();

            await sturtup.Run();
        }
    }
}
