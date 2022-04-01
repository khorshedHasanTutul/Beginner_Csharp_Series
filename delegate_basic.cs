using System ;

public delegate void HelloFromDelegate(string msg);


public class Deligate
{
    public static void print(string msg)
    {
        Console.WriteLine(msg);
    }
}