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

    // POST /todo-list-status-changes
    [HttpPost("/todos-list-status-change")]
    public async Task<ActionResult> ChangeTheStatusOf([FromBody] TodoListItemRequestModel request)
    {
        TodoListItemResponseModel? response = await _todoListCatalog.ChangeStatusAsync(request);

        if (response == null)
        {
            return BadRequest("No item with that Id to change the status of");
        }
        else
        {
            return Ok(request);
        }

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
