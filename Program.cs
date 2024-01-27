// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var myData = new MyData
{
    Id = 1,
    Name = "Dazs",
    Description = "yum yum yum..."
};
var dictionary = myData.ToDictionary();

foreach (var item in dictionary)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}