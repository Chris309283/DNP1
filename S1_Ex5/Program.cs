using S1_Ex5;

Calculator cal = new();

 Console.WriteLine(cal.Add(2,3));
 
 Console.WriteLine(cal.Add(new []{2,3,5}));
 
 Console.WriteLine($"Biggest number is {cal.Max()}");