using System ;

public abstract class AbstractClass:I5
{
    public abstract void print();
    public void print2()
    {
        Console.WriteLine("Abstract Interface");
    }
}

public class class3:AbstractClass
{
    public override void print(){
        Console.WriteLine("Hello Abstract Class");
    }
}

public interface I5
{
    void print2();
}
// public interface I6:AbstractClass
// {
    
// }