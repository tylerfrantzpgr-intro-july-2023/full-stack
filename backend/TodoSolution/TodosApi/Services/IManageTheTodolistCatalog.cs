namespace TodosApi;

public interface IManageTheTodolistCatalog
{
    Task<TodoListItemResponseModel> AddTodoItemAsync(TodoListCreateModel request);
    Task<TodoListItemResponseModel?> ChangeStatusAsync(TodoListItemRequestModel request);
    Task<CollectionResponse<TodoListItemResponseModel>> GetFullListAsync();
}