using System ;

class students
{
    private int _id;
    private string _name;
    private double _passMark;

    public void SetId(int Id)
    {
        if(Id<0){
            throw new Exception("Student Id should be greater than 0");
        }
        this._id=Id;
    }

    public int GetId(){
        return this._id;
    }
}

class Teacher
{
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public void printFullName()
    {
        Console.WriteLine(FirstName+LastName);
    }
}