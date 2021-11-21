Console.Write("Enter name: ");
string? name = Console.ReadLine();
if (name.ToLower() == "alex") 
{
    Console.WriteLine($"Hello, {name}!");
}
else 
{
    Console.WriteLine("Hello, user");
}

// int a = new Random().Next(4, 15);
// int b = new Random().Next(4, 15);
// Console.WriteLine(a + b);
