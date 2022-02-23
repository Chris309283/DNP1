using System.Collections;

namespace S2_Ex1;

public class Company
{
    private ArrayList Employees = new ArrayList();

    public double GetMonthlySalaryTotal()
    {
        return Employees.Cast<Employee>().Sum(emp => emp.GetMonthlySalary());
    }

    public void HireNewEmployee(Employee emp)
    {
        Employees.Add(emp);
    }
}