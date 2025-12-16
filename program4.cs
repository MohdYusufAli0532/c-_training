// See https://aka.ms/new-console-template for more information

using System;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;





public delegate void delegate1();


//In C#, a multicast delegate is a delegate that can reference more than one method. When you invoke it, all the methods it points to are executed, in the order they were added.

//This is commonly used in events, callbacks, and notification systems.


class Day7
{
    public static void MethodA()
    {
        Console.WriteLine("Method A called");
    }
    public static void MethodB()
    {
        Console.WriteLine("Method B called");
    }

    public static int square(int x) //so here we can create delegate for this method, but we will use func delegate here

    {
        return x * x;

    }

    public static void show(string msg) //here we can also create delegate for this method, but we will use action delegate here
    {
        Console.WriteLine(msg);

    }
    public static bool isEven(int number) //here we can also create delegate for this method, but we will use predicate delegate here
    {
        return number % 2 == 0;
    }
    public static void Main(string[] args)
    {
        // Create delegate instances
        delegate1 del1 = MethodA;
        delegate1 del2 = MethodB;

        // Combine delegates to create a multicast delegate
        delegate1 multicastDel = del1 + del2;
        // Invoke the multicast delegate
        multicastDel();




        //Csharp provides us built in delegates also like Action, Func, Predicate etc.-
        //        In C#, built-in delegates are predefined delegate types provided by .NET so you don’t have to create your own delegates for common method signatures.



        //sir
        //func->it returns value
        //action->it does not return value
        //predicate->it returns boolean value



        //The most commonly used built -in delegates are:


        //        1.Action

        //Represents a delegate that returns void

        //Can take 0 to 16 input parameters

        //Used when you only want to perform an action

        //2.Func

        //Represents a delegate that returns a value

        //Can take 0 to 16 input parameters

        //The last type parameter is always the return type

        //3.Predicate < T >

        //Represents a delegate that returns bool

        //Takes one parameter

        //Commonly used for condition checking

        //4.EventHandler

        //Represents a delegate used for events

        //Returns void

        //Accepts object sender and EventArgs e

        //5.EventHandler < TEventArgs >

        //Generic version of EventHandler

        //Used for strongly typed event data

        //6. Comparison<T>

        //Represents a delegate that compares two objects

        //Returns an int indicating sort order

        //7. Converter<TInput, TOutput>

        //Represents a delegate that converts one type to another

        //8. Func<Task> / Func<Task<T>>

        //Used for asynchronous methods

        //Returns a Task or Task<T>



        //Func <in T, out TResult >

        Func<int, int> f1 = square;  //first one is datatype of parameter, second one is return type

        Console.WriteLine("Square of 5 is: " + f1(5));



        Action<string> a1 = show; //here string is parameter type, action does not return anything
        a1("UCER");

        Predicate<int> p1 = isEven; //here int is parameter type, predicate returns boolean value

        Console.WriteLine("Is 45 even? " + p1(45));







        //Anonymous Method in C#

        //An anonymous method is a method without a name that is defined inline and assigned directly to a delegate.
        //It is used when the method is needed only once and does not require a separate named method





        Func<int, int> squareAnon = delegate (int x) //old style
        {
            return x * x;
        };

        Console.WriteLine("Square of 6 using anonymous method: " + squareAnon(6));


        //Or



        //Lambda Function(Lambda Expression) in C#

        //A lambda function is a short, anonymous function written using the => operator.
        //It is mainly used to pass behavior as data, especially with delegates, LINQ, and events.


        Func<int, int> cubeAnon = (x) => {
            return x * x * x;
        };
        Console.WriteLine("Cube of 6 using anonymous method: " + cubeAnon(6));

        Func<int,int,int,int> greatest= (a, b, c) =>
        {
            if (a >= b && a >= c)
                return a;
            else if (b >= a && b >= c)
                return b;
            else
                return c;
        };

        Console.WriteLine("Greatest among 3, 7 and 5 is: " + greatest(3, 7, 5));

        Action<int> a2=(x) => Console.WriteLine("Square is: " + x*x);

        a2(15);

        Predicate<int> p2= (x) => x % 2 == 0;

        Console.WriteLine("Is 20 even? " + p2(20));


        //Dynamic Polymorphism in C# Using Delegates

        //In C#, dynamic polymorphism means that the method to be executed is decided at runtime.
        //While it is commonly achieved using method overriding, delegates also provide dynamic polymorphism because they decide which method to invoke at runtime.

        //How Delegates Enable Dynamic Polymorphism

        //A delegate can refer to different methods with the same signature at different times.
        //The actual method call is resolved dynamically at runtime, not at compile time.

        //👉 This behavior is called dynamic polymorphism due to delegates
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //Event – Publisher–Subscriber Pattern (C#)

        //        The Publisher–Subscriber(Pub–Sub) pattern in C# is implemented using delegates and events.
        //It allows loose coupling between components:

        //        Publisher raises(publishes) an event

        //        Subscriber listens to(subscribes) and handles the event

        //1. Basic Idea

        //        Publisher

        //        Defines an event

        //        Raises the event when something happens

        //        Subscriber

        //Subscribes to the event

        //Executes a method when the event is raised

        //📌 Subscribers do not know how the publisher works internally..







        //Publisher-Subscriber Example in C#

        Button btn = new Button(); //publisher object

        btn.onClick += program.ButtonClicked; //subscriber subscribes to event  
        btn.onClick += program.ButtonClicked;

        btn.Click(); //simulate button click to raise event


        btn.onClick-=program.ButtonClicked; //unsubscribe from event

        btn.Click(); //simulate button click to raise event


    }
}


class Button  //publisher
{
    public delegate void ClickHandler();

    //delegate type for click event 



    public event ClickHandler onClick; //event based on delegate

    public void Click()
    {
        if (onClick != null)
        {
            onClick(); //raise the event
        }
    }
}


class program //subscriber
{
    public static void ButtonClicked()
    {
        Console.WriteLine("Button was clicked! Event handled in subscriber.");
    }

    //sir->

    //public static void Main(string[] args)
    //{
    //    Button btn = new Button();  //creating object of Button class in main
    //    btn.onClick += ButtonClicked; //subscriber subscribes to event  
    //    btn.Click(); //simulate button click to raise event
    //}   
    //creating object of Button class in main
}
