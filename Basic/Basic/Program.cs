Console.WriteLine("Hello, World!");

int age;
string name =string.Empty;

Console.Write("ism: ");
name = Console.ReadLine();

Console.Write("yosh: ");
age = int.Parse(Console.ReadLine());

Console.WriteLine("________User Info_______");
Console.WriteLine($"Ism: {name}");
Console.WriteLine($"Yosh: {age}");