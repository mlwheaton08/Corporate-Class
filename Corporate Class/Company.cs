namespace Corporate_Class;

public class Company
{
    // Some properties
    public string Name { get; set; }
    public DateTime CreatedOn { get; set; }

    // Create a private property for holding a collection of current employees
    public List<Employee> Employees = new List<Employee>();

    // Create a method that allows a caller to add an employee
    public void AddEmployee(params Employee[] employees) //this makes a list of each employee passed in. awesommmeeeee
    {
        foreach (Employee employee in employees)
        {
            Employees.Add(employee);
        }
    }

    // Create a method that allows a caller to remove an employee
    public void RemoveEmployee(Employee employee)
    {
        Employees.Remove(employee);
    }

    // Create a method that allows a caller to retrieve the list of employees
    public void ListEmployees()
    {
        Employees.ForEach(employee => Console.WriteLine(employee.Name));
    }

    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
    public void CreateCompany(string name, DateTime createdOn)
    {
        Name = name;
        CreatedOn = createdOn;
    }

    public void DisplayCompanyInfo()
    {
        Console.WriteLine($"{Name} was created on {CreatedOn}");
    }
}