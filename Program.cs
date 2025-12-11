// See https://aka.ms/new-console-template for more information
class first
    {
    public first()
    {
        System.Console.WriteLine("This is first class constructor");
    }
    public void one()
    {
               System.Console.WriteLine("This is first class method");

    }
    private void private_one()
        {
               System.Console.WriteLine("This is first class private method");
        }

    public void private_access()     {
        private_one();
    }
}
class second:first
{
    public second()
    {
        System.Console.WriteLine("This is second class constructor");
    }
    public void two()
    {
               System.Console.WriteLine("This is second class method");
    }
}

class Logic
{
       public static void Main(string[] args)
    {
        Student obj=new Student();

        obj.msg();
        obj.show();

        //System.Console.WriteLine("Name:"+obj.name);
        //System.Console.WriteLine("Age:" + obj.age);
        //System.Console.WriteLine("roll Number:" + obj.rollnum);
        //System.Console.WriteLine("Course:" + obj.Course);
        //System.Console.WriteLine("number:" + obj.number);


        Student stu1=new Student("Ali",22,4,"CSE",4342);
        stu1.show();

        //System.Console.WriteLine("Name:" + stu1.name);
        //System.Console.WriteLine("Age:" + stu1.age);
        //System.Console.WriteLine("roll number:" + stu1.rollnum);
        //System.Console.WriteLine("Course:" + stu1.Course);
        //System.Console.WriteLine("Number:" + stu1.number);


        Length obj1 = new Length(12345);
        Length obj2 = new Length("Hello, World!");


        second objectt = new second();
        objectt.one();
        objectt.two();
        objectt.private_access();


    }
        
}
