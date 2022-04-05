using System;
using System.IO;

class Exception_Handling
{
  public void ExceptionHandling()
  {
    StreamReader streamReader= null;
    try
    {
      streamReader = new StreamReader(@"./test.txt");
      Console.WriteLine(streamReader.ReadToEnd());
    }
    catch(Exception ex)
    {
      Console.WriteLine(ex.Message);
    }
    finally
    {
      if(streamReader!=null) streamReader.Close();
      Console.WriteLine("Finally Blocked");
      
    }


  }

}