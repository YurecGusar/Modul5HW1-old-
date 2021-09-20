using System.Threading.Tasks;
using Modul5HW1.Providers.Abstractions;
using Modul5HW1.Services.Abstractions;
using Newtonsoft.Json;

namespace Modul5HW1
{
    public class Startup
    {
        private IUsersClientService _userClient;
        private ITestDataProvider _testValues;
        public Startup(
            IUsersClientService usersClient,
            ITestDataProvider testValues)
        {
            _userClient = usersClient;
            _testValues = testValues;
        }

        public async Task Run()
        {
            var result = await _userClient.GetUsersOnPageAsync(2);

            var result2 = await _userClient.GetUserAsynk(2);

            var result3 = await _userClient.GetUserAsynk(23);

            var result4 = await _userClient.GeUncnownResourceAsync();

            var result5 = await _userClient.GetResourceAsync(2);

            var result6 = await _userClient.GetResourceAsync(23);

            await _userClient.CreateUserAsync(_testValues.ObjCreateUserJson);

            await _userClient.UpdatePutUserAsync(2, _testValues.ObjUpdateUserJson);

            await _userClient.UpdatePathUserAsync(2, _testValues.ObjUpdateUserJson);

            await _userClient.RegisterUserAsync(_testValues.ObjRegUserHavePassJson);

            await _userClient.RegisterUserAsync(_testValues.ObjRegUserDontHavePassJson);

            await _userClient.LoginUserAsync(_testValues.ObjLogUserHavePassJson);

            await _userClient.LoginUserAsync(_testValues.ObjLogUserDontHavePassJson);

            var result9 = await _userClient.GetUsersByDelay(3);

            await _userClient.DeleteUserAsync(2);
        }
    }
}
