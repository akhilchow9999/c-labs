using System;

class Employee
{
    private int _employeeId;
    private string _employeeName;
    private string _address;
    private string _city;
    private string _department;
    private float _salary;

    public int EmployeeId
    {
        set
        {
            if (value.ToString().Length <= 4)
                _employeeId = value;
            else
                Console.WriteLine("Enter Valid Id");
        }
        get => _employeeId;
    }

    public string EmployeeName
    {
        set
        {
            if (value.Length <= 25)
                _employeeName = value;
            else
                Console.WriteLine("String Limit Exceeded");
        }
        get => _employeeName;
    }

    public string Address
    {
        set
        {
            if (value.Length <= 50)
                _address=value;
            else
                Console.WriteLine("String Limit Exceeded");
        }
        get => _address;
    }

    public string City
    {
        set
        {
            if (value.Length <= 15)
                _city = value;
            else
                Console.WriteLine("Wrong City");
        }
        get => _city;
    }

    public string Department
    {
        set
        {
            if (value.Length <= 10)
                _department = value;
            else
                Console.WriteLine("String Limit Exceeded");
        }
        get => _department
;
    }

    public float Salary
    {
        set
        {
            if (value.ToString().Length <= 10)
                _salary = value;
            else
                Console.WriteLine("String Limit Exceeded");
        }
        get => _salary;
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee();
        Console.WriteLine("Enter Employee Id");
        employee.EmployeeId = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Employee Name");
        employee.EmployeeName = Console.ReadLine();
        Console.WriteLine("Enter Address");
        employee.Address = Console.ReadLine();
        Console.WriteLine("Enter City Name");
        employee.City = Console.ReadLine();
        Console.WriteLine("Enter Employee Department");
        employee.Department = Console.ReadLine();
        Console.WriteLine("Enter Employee Salary");
        employee.Salary = float.Parse(Console.ReadLine());
        
        Employee[] e = new Employee[10];
        for(int i=0; i<10; i++)
        {
            e[i] = new Employee();
            Console.WriteLine("Enter Employee Id");
            e[i].EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            e[i].EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            e[i].Address = Console.ReadLine();
            Console.WriteLine("Enter City Name");
            e[i].City = Console.ReadLine();
            Console.WriteLine("Enter Employee Department");
            e[i].Department = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            e[i].Salary = float.Parse(Console.ReadLine());
        }
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Employee-"+i+" Name: " + e[i].EmployeeName);
            Console.WriteLine("Salary of Employee-"+i+": " + e[i].Salary);
        }
    }
}
