using Microsoft.AspNetCore.Mvc;
using capi.Model;
using capi.Tools;

namespace capi.Controllers;

[ApiController]
[Route("[controller]")]
public class ToDoController : ControllerBase
{
    private readonly DBServiceProvider<ToDo> _serviceProvider;

    public ToDoController(DBService service)
    {
        this._serviceProvider = new DBServiceProvider<ToDo>(service);
    }

    [HttpGet(Name = "")]
    public IEnumerable<ToDo> Get()
    {
        Console.WriteLine("Get");
        return _serviceProvider.Get();
    }

    [HttpPost(Name = "")]
    public ToDo Post(ToDo todo)
    {
        return _serviceProvider.Create(todo);
    }
}
