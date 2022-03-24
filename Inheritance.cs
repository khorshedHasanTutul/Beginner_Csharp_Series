using System;

public class Employee 
{
    public string firstName;
    public string lastName;
    public void fullName()
    {
        Console.WriteLine("Fullname is {0} {1}",firstName,lastName);
    }
}

public class FullTimeEmployee:Employee
{
    public int yearlySalary= 500000;
}

public class PartTimeEmployee:Employee
{
    public int hourlySalary = 1000;
}