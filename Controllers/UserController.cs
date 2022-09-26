using Microsoft.AspNetCore.Mvc;
using capi.Model;
using capi.Tools;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace capi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly DBService service;
    private readonly DBServiceProvider<User> _serviceProvider;

    public UserController(DBService service)
    {
        this.service = service;
        this._serviceProvider = new DBServiceProvider<User>(service);
    }

    [HttpGet(Name = "user")]
    public IEnumerable<User> Get()
    {
        return _serviceProvider.Get();
    }

    [HttpGet("user/notification/{key}", Name = "UserById")]
    public async Task<IEnumerable<Notification>> GetNotifications(string key)
    {
        var notificationProvider = service.database.GetCollection<Notification>(typeof(Notification).Name);
        var ToDoProvider = service.database.GetCollection<ToDo>(typeof(ToDo).Name);
        var userProvider = service.database.GetCollection<User>(typeof(User).Name);

        var results = from notification in notificationProvider.AsQueryable()
                      join todo in ToDoProvider.AsQueryable() on notification.ToDoKey equals todo.Key
                      join user in userProvider.AsQueryable() on todo.userKey equals user.Key
                      where user.Key == key
                      select notification;

        var r = await results.Skip(0).Take(10).ToListAsync();

        return r;
    }

    [HttpPost(Name = "User")]
    public User Post(User user)
    {
        return _serviceProvider.Create(user);
    }
}

public struct Test
{
    public Notification notification { readonly get; set; }

    public User user { readonly get; set; }
}
