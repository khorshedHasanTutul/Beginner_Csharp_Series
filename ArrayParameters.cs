using System ; 

namespace C_LEARN
{
    class Arrayparameters
    {
        public void printArrays(params int[] numbers)
        {
            for(int i=0;i<numbers.Length;i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}