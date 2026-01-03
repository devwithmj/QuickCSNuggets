//Quick C# Nuggets #2
//When NOT to use `var
//Youtuber: devwithmj
//youtube.com/devwithmj
//github.com/devwithmj

var client = new HttpClient();

var customers = new List<Customer>();

record Customer(string Name, string City);