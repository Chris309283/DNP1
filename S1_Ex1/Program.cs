// See https://aka.ms/new-console-template for more information

/*
 var name = "Master";
Console.WriteLine("Hello "+ name +"!");
Console.WriteLine($"Hello {name}!");
Console.WriteLine($"Hello {name.ToUpper()}!");
*/

var names = new[] {"Christopher", "Vlad", "Eliza", "Tomas"};
foreach (var name in names)
{
 Console.WriteLine($"Hello {name.ToUpper()}!");
}

