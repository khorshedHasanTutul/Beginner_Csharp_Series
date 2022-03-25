using System;
using PATA=ProjectA.TeamA;
using ProjectA;

namespace C_LEARN
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Employee2 Emp2 = new Employee2("Hello Hasan Tutul");
            var PTE2= new PartTimeEmployeeX();
            PTE2.printFullName();
            SomethingA a = new SomethingA();
            CallConstructor p=new CallConstructor("Khorshed","Hasan Tutul");
            CallConstructor q= new CallConstructor();
            q.printFullName();
            p.printFullName();
            a.SayHello();
            ReadingWriteline readingWriteline = new ReadingWriteline();
            ArrayIntroducing arrayIntro = new ArrayIntroducing();
            Arrayparameters passArray = new Arrayparameters();
            PATA.print();

            Employee3 emp3=new childEmployee();
            // call read & readingWriteline program 
            // readingWriteline.ReadUSer();
            // arrayIntro.takeInputArray();
            // arrayIntro.printArray();
            int[] numbers = new int[5];
            for(int i=0; i < 5 ; i++)
            {
                numbers[i]=i;
            }
            passArray.printArrays(numbers);

            Console.WriteLine("Hello World");

        }
    }
}