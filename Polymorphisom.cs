using System;

public class Employee5
{
    public string firstName = "Khorshed Hasan ";
    public string lastName = "Tutul";

    public virtual void printFullName()
    {
        Console.WriteLine("FullName is {0} {1}", firstName, lastName);
    }
}

public class PartTimeEmployee5 : Employee5
{
    public override void printFullName()
    {
        Console.WriteLine("FullName is {0} {1} - PArttimeEmployee", firstName, lastName);
    }
}

public class FullTImeEmployee5 : Employee5
{
    public override void printFullName()
    {
        Console.WriteLine("FullName is {0} {1} - FullTimeEmployee", firstName, lastName);
    }
}

public class TempEmployee5 : Employee5
{
    public override void printFullName()
    {
        Console.WriteLine("FullName is {0} {1} - Temporary Employee", firstName, lastName);
    }
}


