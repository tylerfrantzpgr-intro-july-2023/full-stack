namespace TodosApi;

public class StatusCyclerTwo : IProvideStatusCycling
{

    private static readonly TodoItemStatus[] _statusCycle = new[]
    {
        TodoItemStatus.Later,
        TodoItemStatus.Now,
        TodoItemStatus.Waiting,
        TodoItemStatus.Completed
    };
    public TodoListItemResponseModel ProvideNextStatusFrom(TodoListItemResponseModel savedItem)
    {
 
        var currentStatus = savedItem.Status;
        var currentStatusIndex = Array.IndexOf(_statusCycle, currentStatus);
        var nextStatusIndex = (currentStatusIndex + 1) % _statusCycle.Length;
        var newStatus = _statusCycle[nextStatusIndex];

        return savedItem with { Status = newStatus };
    }
}

