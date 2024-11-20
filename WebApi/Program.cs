using WebApi;

int id = 1;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
List<Person> users = new List<Person>
{
    new() { Id=id++,Name="����",Age=17},
    new() { Id=id++,Name="������",Age=18},
    new() { Id=id++,Name="�����",Age=20},
    new() { Id=id++,Name="������ �����",Age=79}
};
app.MapGet("/api/users",()=>users);
app.MapGet("/api/users/{id}",(int id) =>
{
    Person? user = users.FirstOrDefault(p=>p.Id==id);
    if (user == null) return Results.NotFound(new {Message="������������ �� ������"});
    return Results.Json(user);
});
app.MapDelete("/api/users/{id}", (int id) =>
{
    Person? user = users.FirstOrDefault(p => p.Id == id);
    if (user == null) return Results.NotFound(new { Message = "������������ �� ������" });
    users.Remove(user);
    return Results.Json(user);
});
app.MapPost("/api/users", (Person user) =>
{
    user.Id = id++;
    users.Add(user);
    return user;
});
app.MapPut("/api/users", (Person userData) =>
{
    var user = users.FirstOrDefault(p => p.Id == userData.Id);
    if (user == null) return Results.NotFound(new { Message = "������������ �� ������" });
    user.Age = userData.Age;
    user.Name = userData.Name;
    return Results.Json(user);
});
app.Run();
