// See https://aka.ms/new-console-template for more information


using Microsoft.Win32.SafeHandles;
using System;
using static SomeClass;



//we can make delegate here also but better to make it inside class so that it will be related to that class only
//public delegate void delegate1(); //delegate declaration->now it will be in dedault namespace only.
class SomeClass
{
    public delegate void delegate1();

    public delegate void delegate2(int x);

    public delegate void delegate3(int x, int y);

    public delegate int delegate4(int a, int b);

    public void method1()
    {
        Console.WriteLine("method1 called");
    }
    

    public static void method2()
    {
        Console.WriteLine("method2 called");
    }
    public void method3(int x)
    {
               Console.WriteLine("method3 called: "+x);
    
    }
    public void method4(int x, int y)
    {
        Console.WriteLine("method4 called: " + (x + y));
    }
   public void method5()
    {
        Console.WriteLine("method5 called");
    }
    public int addition(int a, int b)
    {
        return a + b;
    }

    public int subtraction(int a, int b)
    {
        return a - b;
    }


    public int multiplication(int a, int b)
    {
        return a* b;
    }

    
}


class Test
{
    static void Main(string[] args)
    {
        SomeClass obj = new SomeClass();


        //Delegate is not dependent on object (it is not instance member instead it is class member (something like static))

        //delegate prototype and method assigned prototype should be same   
        delegate1 del1 = obj.method1;  //it is not proper way to assign method to delegate-because there will be multiple classes so make sure to refer class also to not be consfused
        //so the correct way is:
        SomeClass.delegate1 d1=obj.method1; //correct way to assign method to delegate



        del1(); // Invoking method1 using delegate
        delegate2 d3 = obj.method3;
        d3(3);


        obj.method1();
        SomeClass.method2();

        delegate3 d4 = obj.method4;

        d4(4, 5);

        del1=method2;

        del1();

        del1=obj.method5;

        del1();

        delegate4 delegate30=obj.multiplication;
        delegate4 delegate31=obj.addition;
        delegate4 delegate32=obj.subtraction;


        Console.WriteLine(delegate30(10, 5));
        Console.WriteLine(delegate31(20, 10));
        Console.WriteLine(delegate32(10, 5));

        Console.WriteLine("Select 1 for addition, 2 for subtraction, 3 for multiplication:");
        

        int choice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter two number to perform the operation");

        int x= Convert.ToInt32(Console.ReadLine());

        int y = Convert.ToInt32(Console.ReadLine());

      

        switch(choice)
        {
            case 1:
                Console.WriteLine("Addition: "+delegate31(x, y));
                break;
            case 2:
                Console.WriteLine("Subtraction: "+delegate32(x, y));
                break;
            case 3:
                Console.WriteLine("Multiplication: "+delegate30(x, y));
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }

        //One imp concepts left->delegates as parameters
    }


}
