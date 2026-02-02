// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var a = int.Parse(Console.ReadLine());

switch (a)
{
    case 1: Console.WriteLine("Bir");break;
    case 2: Console.WriteLine("Ikki");break;
    case 3: Console.WriteLine("Uch");break;
    default: Console.WriteLine("Nothing");break;
}

string son = a switch
{
    1 => "bir",
    2 => "ikki",
    3 => "uch",
    _ => "nothing"
};

Console.WriteLine(son);

var x = int.Parse(Console.ReadLine());
var y = int.Parse(Console.ReadLine());

switch (x, y)
{
    case ( <= 1, >= 2): Console.WriteLine("Bir ikki"); break;
    case ( 1, _): Console.WriteLine("Bir Bir"); break;

}
