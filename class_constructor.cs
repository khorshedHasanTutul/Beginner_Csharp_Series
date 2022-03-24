using System ;

class CallConstructor
{
    string firstName;
    string lastName;
    public CallConstructor():this("No FirstName","No lastName")
    {
        
    }
    public CallConstructor(string _firstName, string _lastName)
    {
        this.firstName=_firstName;
        this.lastName=_lastName;
    }
    public void printFullName()
    {
        Console.WriteLine("FullName is {0} {1}",firstName,lastName);
    }
}