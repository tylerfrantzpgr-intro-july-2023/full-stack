namespace TodosApi;

public interface IManageTheTodolistCatalog
{
    Task<TodoListItemResponseModel> AddTodoItemAsync(TodoListCreateModel request);
    Task<CollectionResponse<TodoListItemResponseModel>> GetFullListAsync();
}