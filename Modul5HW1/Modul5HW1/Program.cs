using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Modul5HW1.Models;
using Modul5HW1.Models.Items;
using Modul5HW1.Services;
using Newtonsoft.Json;

namespace Modul5HW1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var userClient = new UsersClientService();

            var result = await userClient.MyGetAsync<ListItem<User>>("https://reqres.in/api/users?page=2");
            var result2 = await userClient.MyGetAsync<SingleItem<User>>("https://reqres.in/api/users/2");
            var result3 = await userClient.MyGetAsync<SingleItem<User>>("https://reqres.in/api/users/23");
            var result4 = await userClient.MyGetAsync<ListItem<Resource>>("https://reqres.in/api/unknown");
            var result5 = await userClient.MyGetAsync<SingleItem<Resource>>("https://reqres.in/api/unknown/2");
            var result6 = await userClient.MyGetAsync<SingleItem<Resource>>("https://reqres.in/api/unknown/23");
            var serObj = JsonConvert.SerializeObject(new
            {
                name = "morpheus",
                job = "leader"
            });
            var result7 = await userClient.MyPostAsync<UserCreateInfo>("https://reqres.in/api/users", serObj);
            var serObj2 = JsonConvert.SerializeObject(new
            {
                name = "morpheus",
                job = "zion resident"
            });
            var result8 = await userClient.MyPutAsync<UserCreateInfo>("https://reqres.in/api/users/2", serObj2);
            Console.WriteLine(result8.UpdatedAt);
            Console.WriteLine("Good");
        }
    }
}
