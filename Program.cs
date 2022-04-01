using System;
using PATA = ProjectA.TeamA;
using ProjectA;

namespace C_LEARN
{
    class Program
    {
        public static void Main(string[] args)
        {

            HelloFromDelegate deligate=new HelloFromDelegate(Deligate.print);
            deligate("Hey delegate do you exist to invoke a function only");

            C c=new C();
            c.printC();
            Program2 p2=new Program2();
            ((I1)p2).InterfaceMethod();
            ((I2)p2).InterfaceMethod();
            class3 c3=new class3();
            c3.print();
            c3.print2();

            students student = new students();
            student.SetId(50);
            Console.WriteLine(student.GetId());
            Teacher teacher = new Teacher();
            teacher.FirstName = "Khorshed Hasan Mahmudul Alom";
            teacher.LastName = "Tutul";
            teacher.printFullName();
            Console.WriteLine(teacher.FirstName);
            Structs structs = new Structs
            {
                Id = 25,
                Name = "Khorshed HAsan Tutul"
            };
            structs.printFullData();
            ICustomer2 IC2=new student1();
            IC2.Print1();
            IC2.Print2();
            // Employee2 Emp2 = new Employee2("Hello Hasan Tutul");
            // var PTE2= new PartTimeEmployeeX();
            // PTE2.printFullName();
            // SomethingA a = new SomethingA();
            // CallConstructor p=new CallConstructor("Khorshed","Hasan Tutul");
            // CallConstructor q= new CallConstructor();
            // q.printFullName();
            // p.printFullName();
            // a.SayHello();
            // ReadingWriteline readingWriteline = new ReadingWriteline();
            // ArrayIntroducing arrayIntro = new ArrayIntroducing();
            // Arrayparameters passArray = new Arrayparameters();
            // PATA.print();

            // Employee3 emp3=new childEmployee();
            // call read & readingWriteline program 
            // readingWriteline.ReadUSer();
            // arrayIntro.takeInputArray();
            // arrayIntro.printArray();
            Employee5[] employees = new Employee5[4];
            employees[0] = new Employee5();
            employees[1] = new PartTimeEmployee5();
            employees[2] = new FullTImeEmployee5();
            employees[3] = new TempEmployee5();
            employees[2].printFullName();

            foreach (Employee5 e in employees)
            {
                e.printFullName();
            }

            // int[] numbers = new int[5];
            // for(int i=0; i < 5 ; i++)
            // {
            //     numbers[i]=i;
            // }
            // passArray.printArrays(numbers);

            // Console.WriteLine("Hello World");

        }
    }
}