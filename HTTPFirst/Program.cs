using System.Text;

HttpClient httpClient = new HttpClient();

//HttpRequestMessage
//using HttpRequestMessage request = 
//    new HttpRequestMessage(HttpMethod.Get,"https://www.mail.ru");
//using HttpResponseMessage response =
//    await httpClient.SendAsync(request);
//Console.WriteLine($"Status code:{response.StatusCode}");
//Console.WriteLine("Headers");
//foreach(var header in response.Headers)
//{
//    Console.Write($"{header.Key}:");
//    foreach(var headerValue in header.Value)
//    {
//        Console.WriteLine(headerValue);
//    }
//}
//Console.WriteLine();
//Console.WriteLine("Content:");
//string content = await response.Content.ReadAsStringAsync();
//Console.WriteLine(content);

//GetAsync()
//using HttpResponseMessage response =
//    await httpClient.GetAsync("https://www.mail.ru");
//string content = await response.Content.ReadAsStringAsync();
//Console.WriteLine(content);

//GetStringAsync
//string content = await httpClient.GetStringAsync("https://www.mail.ru");
//Console.WriteLine(content);

//GetByteArrayAsync
//byte[] buffer= await httpClient.GetByteArrayAsync("https://www.mail.ru");
//Console.WriteLine(Encoding.UTF8.GetString(buffer));

//GetStreamAsync
using Stream stream = 
    await httpClient.GetStreamAsync("https://www.mail.ru");
StreamReader reader = new StreamReader(stream);
string content = await reader.ReadToEndAsync();
Console.WriteLine(content);