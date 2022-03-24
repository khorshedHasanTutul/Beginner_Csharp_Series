using System;

namespace C_LEARN
{
    class ReadingWriteline
    {
        public void ReadUSer()
        {
            Console.WriteLine("Enter Your FirstName");
            var firstName = Console.ReadLine();
            Console.WriteLine("Hello " + firstName);
        }
    }
}
