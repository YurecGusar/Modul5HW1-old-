using System.Threading.Tasks;
using Modul5HW1.Models;
using Modul5HW1.Models.Items;
using Modul5HW1.Services.Abstractions;

namespace Modul5HW1.Services
{
    public class UsersClientService : IUsersClientService
    {
        private IMyHttpMethodsService _myHttp;

        public UsersClientService(IMyHttpMethodsService myHttp)
        {
            _myHttp = myHttp;
        }

        public async Task<ListItem<User>> GetUsersOnPageAsync(int page)
        {
            var result = await _myHttp.MyGetAsync<ListItem<User>>(
                $"https://reqres.in/api/users?page={page}");
            return result;
        }

        public async Task<SingleItem<User>> GetUserAsynk(int id)
        {
            var result = await _myHttp.MyGetAsync<SingleItem<User>>(
                $"https://reqres.in/api/users/{id}");
            return result;
        }

        public async Task<ListItem<Resource>> GeUncnownResourceAsync()
        {
            var result = await _myHttp.MyGetAsync<ListItem<Resource>>(
                "https://reqres.in/api/unknown");
            return result;
        }

        public async Task<SingleItem<Resource>> GetResourceAsync(int id)
        {
            var result = await _myHttp.MyGetAsync<SingleItem<Resource>>(
                $"https://reqres.in/api/unknown/{id}");
            return result;
        }

        public async Task CreateUserAsync(string jsonUser)
        {
            await _myHttp.MyPostAsync<SingleItem<User>>("https://reqres.in/api/users", jsonUser);
        }

        public async Task UpdatePutUserAsync(int id, string content)
        {
            await _myHttp.MyPutAsync<UserCreateInfo>($"https://reqres.in/api/users/{id}", content);
        }

        public async Task UpdatePathUserAsync(int id, string content)
        {
            await _myHttp.MyPathAsync<UserCreateInfo>($"https://reqres.in/api/users/{id}", content);
        }

        public async Task DeleteUserAsync(int id)
        {
            await _myHttp.DeleteAsync(id);
        }

        public async Task RegisterUserAsync(string content)
        {
            await _myHttp.MyPostAsync<Register>("https://reqres.in/api/register", content);
        }

        public async Task LoginUserAsync(string content)
        {
            await _myHttp.MyPostAsync<Register>("https://reqres.in/api/login", content);
        }

        public async Task<ListItem<User>> GetUsersByDelay(int delay)
        {
            var result = await _myHttp.MyGetAsync<ListItem<User>>(
                $"https://reqres.in/api/users?delay={delay}");
            return result;
        }
    }
}
