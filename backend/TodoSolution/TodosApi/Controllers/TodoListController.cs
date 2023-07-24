

using Marten;

namespace TodosApi.Controllers;

[ApiController]
public class TodoListController : ControllerBase
{

    private readonly IDocumentSession _documentSession;

    public TodoListController(IDocumentSession documentSession)
    {
        _documentSession = documentSession;
    }

    [HttpPost("/todo-list")]
    public async Task<ActionResult> AddTodoItem([FromBody] TodoListCreateModel request)
    {

        // if we get here, this is valid.
        // add it to the database.
        TodoListCreateModel response = await _todoListCatalog.AddTodoItemAsync(request);
        // send it back to them. 
        return Ok(response);
    }


    // GET /todo-list
    [HttpGet("/todo-list")]
    public async Task<ActionResult> GetTodoList()
    {
        // fake this for a moment
        var list = await _documentSession.Query<TodoListItemResponseModel>().ToListAsync();

        // var response = new CollectionResponse<TodoListItemResponseModel>(list);
        return Ok(list);
    }
}