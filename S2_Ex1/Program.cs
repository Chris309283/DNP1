using S2_Ex1;

var company = new Company();


Employee emp1 = new FullTimeEmployee("Christopher",110000);
var emp2 = new PartTimeEmployee("Vlad",220,148);
var emp3 = new FullTimeEmployee("Tomas", 22000);

company.HireNewEmployee(emp1);
company.HireNewEmployee(emp2);
company.HireNewEmployee(emp3);

Console.WriteLine(company.GetMonthlySalaryTotal());
Console.WriteLine((220 * 148)+22000+110000);