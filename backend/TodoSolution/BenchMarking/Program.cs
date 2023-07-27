// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using TodosApi;
using TodosApi.Models;

Console.WriteLine("Hello, World!");
var summary = BenchmarkRunner.Run<BenchMarkIt>();

[MemoryDiagnoser, HtmlExporter]
public class BenchMarkIt
{
    private readonly IProvideStatusCycling _provideStatusCycling;
    private readonly Guid _id = Guid.NewGuid();
    public BenchMarkIt()
    {
        _provideStatusCycling = new StatusCyclerTwo();
    }

    [Benchmark]
    public TodoListItemResponseModel LaterToNow()
    {
        var input = new TodoListItemResponseModel(_id, "Tacos", TodoItemStatus.Later);
        return _provideStatusCycling.ProvideNextStatusFrom(input);
    }
    [Benchmark]
    public TodoListItemResponseModel NowToWaiting()
    {
        var input = new TodoListItemResponseModel(_id, "Tacos", TodoItemStatus.Now);
        return _provideStatusCycling.ProvideNextStatusFrom(input);
    }
    
    [Benchmark]
    public TodoListItemResponseModel WaitingToCompleted()
    {
        var input = new TodoListItemResponseModel(_id, "Tacos", TodoItemStatus.Waiting);
        return _provideStatusCycling.ProvideNextStatusFrom(input);
    }
    [Benchmark]
    public TodoListItemResponseModel CompletedToWaiting()
    {
        var input = new TodoListItemResponseModel(_id, "Tacos", TodoItemStatus.Completed);
        return _provideStatusCycling.ProvideNextStatusFrom(input);
    }
}