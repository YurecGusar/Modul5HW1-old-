using System.Threading.Tasks;
using Modul5HW1.Models;
using Modul5HW1.Models.Items;

namespace Modul5HW1.Services.Abstractions
{
    public interface IUsersClientService
    {
        public Task<ListItem<User>> GetUsersOnPageAsync(int page);
        public Task<SingleItem<User>> GetUserAsynk(int id);
        public Task<ListItem<Resource>> GeUncnownResourceAsync();
        public Task<SingleItem<Resource>> GetResourceAsync(int id);
        public Task CreateUserAsync(string jsonUser);
        public Task UpdatePutUserAsync(int id, string content);
        public Task UpdatePathUserAsync(int id, string content);
        public Task DeleteUserAsync(int id);
        public Task RegisterUserAsync(string content);
        public Task LoginUserAsync(string content);
        public Task<ListItem<User>> GetUsersByDelay(int delay);
    }
}
