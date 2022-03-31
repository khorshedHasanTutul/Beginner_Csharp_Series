using System ;

public struct Structs
{
    public int Id {get ; set ;}
    public string Name {get ; set ;}

    public Structs(int _id, string _name)
    {
        Id=_id;
        Name= _name;
    }

    public void printFullData()
    {
        Console.WriteLine("FullData is {0} and {1}",Id, Name);
    }
}