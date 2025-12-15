// See https://aka.ms/new-console-template for more information



using System.Windows.Markup;

class parent
{
    public int x, y;
    public parent()
     {
        Console.WriteLine("Parent class constructor1 called");
        x = 0;
        y = 0;
    }
    public parent(int a, int b)


    {
        Console.WriteLine("Parent class constructor2 called");
        x = a;
        y = b;
    }
    public void set()
    {
        x = 10;
        y = 20;
            
    }

   
}
class child:parent
{
    int x, y;
    public child():base(0,0)   // base() is used to call the parent class constructor
    {
        Console.WriteLine("Child class constructor1 called");
        x = 5;
        y = 15;
    }
    public void get()
    {
        this.x = base.x; // base keyword is used to access the members of the parent class
        this.y = base.y; 
    }
    public void put()
    {
        Console.WriteLine("x: " + x); 
        Console.WriteLine("y: " + y);
    }
}
class cons


{
    public cons()
    {
        
        Console.WriteLine("First Constructor");
    }
    public cons(int x):this()    //This will call the first constructor
    {
        Console.WriteLine("Second Constructor with parameter: " + x);
    }
}


//In place of Super() (in Javaa) we use base() in C#

/*
 base() is used to call the constructor of the parent class from the derived class.
1.
2.Base() as a method call: It is used to call super class constructor from the derived class constructor

*/


//static class-Example->

class elonmusk
{
    public static class elonfather  //nested static class
    {
        public static void father()
        {
            Console.WriteLine("Elon Musk's father is Errol Musk");
        }
       
    }
    public static class elonteacher
    {
            public static void teacher()
            {
                Console.WriteLine("Elon Musk's teacher is Peter");
            }
     }


}


class Father
{
    public virtual void thinking()
    {
            Console.WriteLine("Father is thinking in oldish style");
    }
    /* virtual (C#)
 * The 'virtual' keyword is used in a base class to indicate that a method,
 * property, indexer, or event can be overridden in a derived class.
 * 
 * Purpose:
 * - Allows runtime polymorphism.
 * - Lets child classes change (override) the behavior of a method.
 * 
 * Rules:
 * - A virtual method must be overridden using 'override' in the derived class.
 * - If not overridden, the base class version is used.
 * */

}
class Son : Father
{
    public void thinking()
    {
        Console.WriteLine("Son is thinking in modern style");
    }
}
interface Employee_x_work
{
    public bool checkprime(int num);
    void printprime(int limit);  //by default public
    public int calculateSalary(int days);

    

    //Interface specifies the responsibilities of a class without dictating how they should be implemented.
    //100% abstraction
}
class X: Employee_x_work
{
    public bool checkprime(int num)
    {
        if (num <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
    public void printprime(int limit)
    {
        Console.WriteLine("Prime numbers up to " + limit + ":");
        for (int i = 2; i <= limit; i++)
        {
            if (checkprime(i))
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
    public int calculateSalary(int days)
    {
        int dailyWage = 100; // Example daily wage
        return days * dailyWage;
    }
}
class Test
{
    static void Main(string []args)
    {
        cons obj = new cons(10);

        cons obj1=new cons();


       child obj2 = new child(); ;
        obj2.set();
        obj2.get();
        obj2.put();


        /* Static 
 * i. Static Variables -
 *    Static variables belong to the class itself, not to any specific object.
 *    They are shared by all objects of the class and are accessed using the class name.
 * 
 * ii. Static Methods -
 *    Static methods also belong to the class, not objects.
 *    They can be called without creating an object and can only access static members.
 * 
 * iii. Static Class -
 *    A static class cannot be instantiated.
 *    It can contain only static members and is used to group utility or helper methods.
 * */

        elonmusk.elonfather.father();
        elonmusk.elonteacher.teacher();


        /* Sealed
      * A sealed class is a class that cannot be inherited.
      * When a class is marked as sealed, no other class can derive from it.
      * This is used to prevent further extension of the class and to improve security or performance.
      * 
      * A sealed method is a method that cannot be overridden in a derived class.
      * It is used together with 'override' to stop further overriding.
      * 
      * If you need a variable that cannot change:
  *   - Use 'readonly' for fields (value set only in constructor)
  *   - Use 'const' for compile-time constant values
      * */


        /* Method Overloading vs Method Overriding

         * Method Overloading:
         * - Occurs within the same class.
         * - Same method name but different parameters 
         *   (different type, different number, or different order).
         * - Happens at compile time → Compile-time Polymorphism.
         * - No keywords needed (like virtual/override).

         * Method Overriding:
         * - Occurs between base class and derived class.
         * - Same method name, same parameters, same return type.
         * - Base class method must be marked 'virtual'.
         * - Derived class method must use 'override'.
         * - Happens at runtime → Runtime Polymorphism.
         */
        Father obj3= new Son();
        obj3.thinking(); // Calls Son's thinking() due to overriding->Dyanamic Dispatch->depends on new Son()


        /* Interface vs Abstract Class

 * Interface:
 * - A contract that contains only method signatures, properties, events, or indexers.
 * - No implementation (C# 8+ allows default implementation, but not common for beginners).
 * - A class must implement all interface members.
 * - A class can implement multiple interfaces (supports multiple inheritance).
 * - All members are public by default.

 * Abstract Class:
 * - A class that cannot be instantiated.
 * - Can contain both abstract methods (no body) and normal methods (with body).
 * - Can contain fields, constructors, and access modifiers.
 * - A class can inherit only one abstract class (single inheritance).
 * - Abstract methods must be overridden in the derived class.
 */
        X employee = new X();
        employee.printprime(50);
        Console.WriteLine("Salary for 20 days: " + employee.calculateSalary(20));
        Console.WriteLine("Is 29 prime? " + employee.checkprime(29));


    }
}
