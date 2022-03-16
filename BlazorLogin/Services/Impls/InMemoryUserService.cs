﻿using BlazorLogin.Models;

namespace BlazorLogin.Services.Impls;

public class InMemoryUserService : IUserService
{
    public async Task<User?> GetUserAsync(string username)
    {
        User? find = users.Find(user => user.Name.Equals(username));
        return find;
    }
    
    private readonly List<User?> users = new()
    {
        new User("Troels", "Troels1234", "Teacher", 3, 1986),
        new User("Maria", "oneTwo3FOUR", "Student", 2, 2001),
        new User("Anne", "password", "HeadOfDepartment", 5, 1975)        
    };
}