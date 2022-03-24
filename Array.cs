using System;

namespace C_LEARN
{
    class ArrayIntroducing
    {
        int[] arr;

        public ArrayIntroducing()
        {
            arr = new int[5];
        }
        public void takeInputArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }
        }
        public void printArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}