
using TodosApi.Models;

namespace TodosApi.UnitTests;

public class StatusCyclerTests
{
    [Fact]
    public void CanChangeTheStatusFromLaterToNow()
    {
        // Given
        IProvideStatusCycling cycler = new StatusCycler();
        var beforeItem = new TodoListItemResponseModel(Guid.NewGuid(), "Tacos", TodoItemStatus.Later);
        var expectedAfterItem = beforeItem with { Status = TodoItemStatus.Now };

        // When
        var actual = cycler.ProvideNextStatusFrom(beforeItem);
        // Then
        Assert.Equal(expectedAfterItem, actual);
        
    }
    [Fact]
    public void CanChangeTheStatusNowToWaiting()
    {
        // Given
        IProvideStatusCycling cycler = new StatusCycler();
        var beforeItem = new TodoListItemResponseModel(Guid.NewGuid(), "Tacos", TodoItemStatus.Now);
        var expectedAfterItem = beforeItem with { Status = TodoItemStatus.Waiting };

        // When
        var actual = cycler.ProvideNextStatusFrom(beforeItem);
        // Then
        Assert.Equal(expectedAfterItem, actual);

    }
    [Fact]
    public void CanChangeTheStatusWaitingToCompleted()
    {
        // Given
        IProvideStatusCycling cycler = new StatusCycler();
        var beforeItem = new TodoListItemResponseModel(Guid.NewGuid(), "Tacos", TodoItemStatus.Waiting);
        var expectedAfterItem = beforeItem with { Status = TodoItemStatus.Completed };

        // When
        var actual = cycler.ProvideNextStatusFrom(beforeItem);
        // Then
        Assert.Equal(expectedAfterItem, actual);

    }
    [Fact]
    public void CanChangeTheStatusCompletedToLater()
    {
        // Given
        IProvideStatusCycling cycler = new StatusCycler();
        var beforeItem = new TodoListItemResponseModel(Guid.NewGuid(), "Tacos", TodoItemStatus.Completed);
        var expectedAfterItem = beforeItem with { Status = TodoItemStatus.Later };

        // When
        var actual = cycler.ProvideNextStatusFrom(beforeItem);
        // Then
        Assert.Equal(expectedAfterItem, actual);

    }


}

// Later -> Now -> Waiting -> Completed -> Later -> Now }
//Now -> Waiting 
// Waiting -> Completed
// Completed -> Later

