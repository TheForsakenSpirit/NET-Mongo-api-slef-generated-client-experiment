using Microsoft.AspNetCore.Mvc;
using capi.Model;
using capi.Tools;

namespace capi.Controllers;

[ApiController]
[Route("[controller]")]
public class NotificationController : ControllerBase
{
    private readonly DBServiceProvider<Notification> _serviceProvider;

    public NotificationController(DBService service)
    {
        this._serviceProvider = new DBServiceProvider<Notification>(service);
    }

    [HttpGet(Name = "notification")]
    public IEnumerable<Notification> Get()
    {
        Console.WriteLine("Get");
        return _serviceProvider.Get();
    }

    [HttpPost(Name = "notification")]
    public Notification Post(Notification notification)
    {
        return _serviceProvider.Create(notification);
    }
}