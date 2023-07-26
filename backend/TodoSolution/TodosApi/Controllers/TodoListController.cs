﻿

using Marten;

namespace TodosApi.Controllers;

[ApiController]
public class TodoListController : ControllerBase
{

    private readonly IManageTheTodolistCatalog _todoListCatalog;

    public TodoListController(IManageTheTodolistCatalog todoListCatalog)
    {
        this._todoListCatalog = todoListCatalog;
    }

    [HttpPost("/todo-list")]
    public async Task<ActionResult> AddTodoItem([FromBody] TodoListCreateModel request)
    {
        var response = await _todoListCatalog.AddTodoItemAsync(request);
        return Ok(response);
    }


    // GET /todo-list
    [HttpGet("/todo-list")]
    public async Task<ActionResult> GetTodoList()
    {
        var list = await _todoListCatalog.GetFullListAsync();
        return Ok(list);
    }
}
