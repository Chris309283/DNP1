using BlazorLogin.Models;

namespace BlazorLogin.Services;

public interface IUserService
{
    public Task<User?> GetUserAsync(string username);
}