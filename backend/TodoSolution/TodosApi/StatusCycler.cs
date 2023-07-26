namespace TodosApi;

public class StatusCycler : IProvideStatusCycling
{
    public TodoListItemResponseModel ProvideNextStatusFrom(TodoListItemResponseModel savedItem)
    {
        if (savedItem.Status == TodoItemStatus.Now)
        {
            return savedItem with { Status = TodoItemStatus.Waiting };
        }
        if (savedItem.Status == TodoItemStatus.Waiting )
        {
            return savedItem with { Status = TodoItemStatus.Completed };
        }
        if (savedItem.Status == TodoItemStatus.Completed)
        {
            return savedItem with { Status = TodoItemStatus.Later };
        }
        return savedItem with {  Status = TodoItemStatus.Now };
    }
}