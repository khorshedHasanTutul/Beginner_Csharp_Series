using System ; 

interface I1
{
    void InterfaceMethod();
}

interface I2
{
    void InterfaceMethod();
}

public class Program2:I1,I2
{
    void I1.InterfaceMethod()
    {
        Console.WriteLine("Hello Interface");
    }
    void I2.InterfaceMethod()
    {
        Console.WriteLine("Hello Interface I2");
    }
}