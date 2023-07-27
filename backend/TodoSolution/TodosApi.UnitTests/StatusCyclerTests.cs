
using TodosApi.Models;

namespace TodosApi.UnitTests;

public class StatusCyclerTests
{
    private readonly IProvideStatusCycling _cycler;

    public StatusCyclerTests()
    {
        _cycler = new StatusCycler();
    }
    [Fact]
    public void CanChangeTheStatusFromLaterToNow()
    {
        // Given
        
        var beforeItem = new TodoListItemResponseModel(Guid.NewGuid(), "Tacos", TodoItemStatus.Later);
        var expectedAfterItem = beforeItem with { Status = TodoItemStatus.Now };

        // When
        var actual = _cycler.ProvideNextStatusFrom(beforeItem);
        // Then
        Assert.Equal(expectedAfterItem, actual);
        
    }
    [Fact]
    public void CanChangeTheStatusNowToWaiting()
    {
        // Given
       
        var beforeItem = new TodoListItemResponseModel(Guid.NewGuid(), "Tacos", TodoItemStatus.Now);
        var expectedAfterItem = beforeItem with { Status = TodoItemStatus.Waiting };

        // When
        var actual = _cycler.ProvideNextStatusFrom(beforeItem);
        // Then
        Assert.Equal(expectedAfterItem, actual);

    }
    [Fact]
    public void CanChangeTheStatusWaitingToCompleted()
    {
        // Given
        
        var beforeItem = new TodoListItemResponseModel(Guid.NewGuid(), "Tacos", TodoItemStatus.Waiting);
        var expectedAfterItem = beforeItem with { Status = TodoItemStatus.Completed };

        // When
        var actual = _cycler.ProvideNextStatusFrom(beforeItem);
        // Then
        Assert.Equal(expectedAfterItem, actual);

    }
    [Fact]
    public void CanChangeTheStatusCompletedToLater()
    {
        // Given
       
        var beforeItem = new TodoListItemResponseModel(Guid.NewGuid(), "Tacos", TodoItemStatus.Completed);
        var expectedAfterItem = beforeItem with { Status = TodoItemStatus.Later };

        // When
        var actual = _cycler.ProvideNextStatusFrom(beforeItem);
        // Then
        Assert.Equal(expectedAfterItem, actual);

    }


}

// Later -> Now -> Waiting -> Completed -> Later -> Now }
//Now -> Waiting 
// Waiting -> Completed
// Completed -> Later

