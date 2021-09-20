using System.Threading.Tasks;

namespace Modul5HW1.Services.Abstractions
{
    public interface IMyHttpMethodsService
    {
        public Task<T> MyGetAsync<T>(string url);
        public Task<T> MyPostAsync<T>(string url, string content);
        public Task<T> MyPutAsync<T>(string url, string content);
        public Task<T> MyPathAsync<T>(string url, string content);
        public Task DeleteAsync(int id);
    }
}
