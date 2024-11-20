using System.Net;
using System.Net.Http.Json;

HttpClient httpClient = new HttpClient();
//object? data = await httpClient.GetFromJsonAsync("http://localhost:5268/1",typeof(Person));
//if(data is Person person)
//{
//    Console.WriteLine($"Name:{person.name} Age:{person.age}");
//}
using var response = await httpClient.GetAsync("http://localhost:5268/2");
if(response.StatusCode==HttpStatusCode.BadRequest||
    response.StatusCode == HttpStatusCode.NotFound)
{
    Error? error = await response.Content.ReadFromJsonAsync<Error>();
    Console.WriteLine(response.StatusCode);
    Console.WriteLine(error?.Message);
}
else
{
    Person? person = await response.Content.ReadFromJsonAsync<Person>();
    Console.WriteLine($"Name:{person.name} Age:{person.age}");
}
record Person(string name, int age);
record Error(string Message);

