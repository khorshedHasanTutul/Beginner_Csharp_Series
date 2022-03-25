using System ;

public class Employee2
{
    private string FullName {  get;  set; }
    
    public Employee2()
    {
        FullName = "Default full name";
    }
    public Employee2(string fullName)
    {
        FullName = fullName;
    }
    
    virtual public void printFullName(int x)
    {
        Console.WriteLine("Full name is {0}", FullName);
    }
}

public class PartTimeEmployeeX : Employee2
{
    public PartTimeEmployeeX()
    {
        
    }
    public PartTimeEmployeeX(string firstName):base(firstName)
    {

    }
    public void printFullName()
    {
        // Console.WriteLine("Full name is Tutul");
        base.printFullName(5);
    }
}
