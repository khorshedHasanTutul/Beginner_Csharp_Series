using System ;

interface ICustomer1
{
    void Print1();
}

interface ICustomer2:ICustomer1
{
    void Print2();
}

public class student1:ICustomer2
{
    public void Print1()
    {
        Console.WriteLine("Hello world");
    }
    public void Print2()
    {
        Console.WriteLine("Khorshed Hasan Tutul");
    }

}