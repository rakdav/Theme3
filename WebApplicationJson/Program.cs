var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/person", () => new Person("Masha", 17));
app.MapGet("/{id?}", (int? id) =>
{
    if (id is null)
        return Results.BadRequest(new { Message = "Некоректные данные запросы" });
    else if (id != 1)
        return Results.NotFound(new { Message = $"Объект с {id} не существует" });
    else
        return Results.Json(new Person("Arina",18));

});
app.Run();
record Person(string name,int age);
