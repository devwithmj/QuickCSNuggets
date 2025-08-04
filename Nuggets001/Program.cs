// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");
var message = JsonSerializer.Serialize(new { Message = "Hello World!" });
Console.WriteLine(message);