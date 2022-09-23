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

    [HttpGet(Name="ToDo")]
    public IEnumerable<ToDo> Get()
    {
        return _serviceProvider.Get();
    }

    [HttpPost(Name="ToDo")]
    public ToDo Post(ToDo todo)
    {
        return _serviceProvider.Create(todo);
    }
}
