//1.Create a class that contains information about employees of a company and define methods to get/set employee name, job title, and start date.
//2. Consider the concept of aggregation and modify the `Company` class so that you assign employees to a company.
//3.In the `Main` method, create a company, and three employees, and then assign the employees to the company.
//4. Update the `Company` class to write the name of each employee to the console. Consider a method named `ListEmployees()`.


using Corporate_Class;

Company company = new Company();
company.CreateCompany("Mason Inc.", new DateTime(2022, 3, 20));
//company.Name = "Mason Inc.";
//company.CreatedOn = new DateTime(2022, 3, 20);
company.DisplayCompanyInfo();

Employee employee1 = new Employee("Mason", "Wanderer", new DateTime(2023, 1, 1));
//employee1.Name = "Mason";
//employee1.JobTitle = "Wanderer";
//employee1.StartDate = new DateTime(2023, 1, 1);
Employee employee2 = new Employee("Stef", "Developer", new DateTime(2023, 1, 5));
Employee employee3 = new Employee("Jim", "HR", new DateTime(2023, 1, 11));

company.AddEmployee(employee1, employee2, employee3);
Console.WriteLine();
Console.WriteLine("List 1:");
company.ListEmployees();

Console.WriteLine();
Console.WriteLine($"Removing {employee1.Name}");
company.RemoveEmployee(employee1);
Console.WriteLine("List 2:");
company.ListEmployees();