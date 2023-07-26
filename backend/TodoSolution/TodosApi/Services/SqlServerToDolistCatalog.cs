namespace TodosApi.Services;

public class SqlServerToDolistCatalog : IManageTheTodolistCatalog
{
    public Task<TodoListItemResponseModel> AddTodoItemAsync(TodoListCreateModel request)
    {
        throw new NotImplementedException();
    }

    public Task<CollectionResponse<TodoListItemResponseModel>> GetFullListAsync()
    {
        throw new NotImplementedException();
    }
}
