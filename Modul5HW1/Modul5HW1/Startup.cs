using System.Threading.Tasks;
using Modul5HW1.Services.Abstractions;
using Newtonsoft.Json;

namespace Modul5HW1
{
    public class Startup
    {
        private IUsersClientService _userClient;
        public Startup(IUsersClientService usersClient)
        {
            _userClient = usersClient;
        }

        public async Task Run()
        {
            var objCreateUser = JsonConvert.SerializeObject(
                new
                {
                    name = "morpheus",
                    job = "leader"
                });

            var serObj2 = JsonConvert.SerializeObject(
                new
                {
                    name = "morpheus",
                    job = "zion resident"
                });

            var serObj3 = JsonConvert.SerializeObject(
                new
                {
                    email = "eve.holt@reqres.in",
                    password = "pistol"
                });

            var serObj4 = JsonConvert.SerializeObject(
                 new
                 {
                     email = "eve.holt@reqres.in",
                 });

            var serObj5 = JsonConvert.SerializeObject(
                new
                {
                    email = "eve.holt@reqres.in",
                    password = "cityslicka"
                });

            var serObj6 = JsonConvert.SerializeObject(
                new
                {
                    email = "eve.holt@reqres.in"
                });

            var result = await _userClient.GetUsersOnPageAsync(2);

            var result2 = await _userClient.GetUserAsynk(2);

            var result3 = await _userClient.GetUserAsynk(23);

            var result4 = await _userClient.GeUncnownResourceAsync();

            var result5 = await _userClient.GetResourceAsync(2);

            var result6 = await _userClient.GetResourceAsync(23);

            await _userClient.CreateUserAsync(objCreateUser);

            await _userClient.UpdatePutUserAsync(2, serObj2);

            await _userClient.UpdatePathUserAsync(2, serObj2);

            await _userClient.RegisterUserAsync(serObj3);

            await _userClient.RegisterUserAsync(serObj4);

            await _userClient.LoginUserAsync(serObj5);

            await _userClient.LoginUserAsync(serObj6);

            var result9 = await _userClient.GetUsersByDelay(3);

            await _userClient.DeleteUserAsync(2);
        }
    }
}
