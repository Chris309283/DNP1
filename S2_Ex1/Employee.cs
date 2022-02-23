namespace S2_Ex1;

public abstract class Employee
{
    public string Name;

    public Employee(string name)
    {
        this.Name = name;
    }

    public abstract double GetMonthlySalary();
}