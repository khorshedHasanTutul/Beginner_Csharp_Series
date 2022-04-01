using System ;

public class A 
{
    public void printA()
    {
        Console.WriteLine("Hello from print A");
    }
}

public class B
{
    public void printB()
    {
        Console.WriteLine("Hello from print B");
    }
}


public class C
{
    A a=new A();
    B b=new B();
    public void printC()
    {
        a.printA();
        b.printB();
    }
}
