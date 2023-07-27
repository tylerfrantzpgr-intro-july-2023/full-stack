namespace TodosApi;

public class StatusCycler : IProvideStatusCycling
{

    public TodoListItemResponseModel ProvideNextStatusFrom(TodoListItemResponseModel savedItem)
    {
      
        var newStatus = savedItem.Status switch
        {
            TodoItemStatus.Later => TodoItemStatus.Now,
            TodoItemStatus.Now => TodoItemStatus.Waiting,
            TodoItemStatus.Waiting => TodoItemStatus.Completed,
            TodoItemStatus.Completed => TodoItemStatus.Later,
            _ => TodoItemStatus.Later // Talk about this
        };

        return savedItem with { Status = newStatus };
    }
}

