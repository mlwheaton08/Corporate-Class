namespace Corporate_Class;

public class Employee
{
    public string Name { get; set; }
    public string JobTitle { get; set; }
    public DateTime StartDate { get; set; }

    public Employee(string name, string jobTitle, DateTime startDate)
    {
        Name = name;
        JobTitle = jobTitle;
        StartDate = startDate;
    }
}