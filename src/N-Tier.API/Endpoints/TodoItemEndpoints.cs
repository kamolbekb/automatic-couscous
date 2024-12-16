using N_Tier.Application.Models;
using N_Tier.Application.Models.TodoItem;
using N_Tier.Application.Services;

namespace N_Tier.API.Endpoints;

public static class TodoItemEndpoints
{
    public static void MapTodoItemEndpoint(this IEndpointRouteBuilder app)
    {
        var group = app
            .MapGroup("TodoItem/minimal")
            .WithOpenApi()
            .RequireAuthorization();
        group.MapPost("", CreateAsync);
        group.MapGet("", GetAll);
        group.MapPut("/{id:guid}", UpdateAsync); //.AllowAnonymous();
        group.MapDelete("/{id:guid}", DeleteAsync);
    }

    private static async Task<IResult> CreateAsync(CreateTodoItemModel createTodoItemModel,
        ITodoItemService _todoItemService)
    {
        return Results.Ok(ApiResult<CreateTodoItemResponseModel>.Success(
            await _todoItemService.CreateAsync(createTodoItemModel)));
    }

    private static async Task<IResult> UpdateAsync(Guid id, UpdateTodoItemModel updateTodoItemModel,
        ITodoItemService _todoItemService)
    {
        return Results.Ok(ApiResult<UpdateTodoItemResponseModel>.Success(
            await _todoItemService.UpdateAsync(id, updateTodoItemModel)));
    }

    private static async Task<IResult> DeleteAsync(Guid id, ITodoItemService _todoItemService)
    {
        return Results.Ok(ApiResult<BaseResponseModel>.Success(await _todoItemService.DeleteAsync(id)));
    }

    private static IResult GetAll(ITodoItemService _todoItemService)
    {
        return Results.Ok(ApiResult<TodoItemResponseModel>.Success(_todoItemService.GetAll()));
    }
}