using System;
class Student
{
    public String name;
    public int age;
    public int rollnum;
    public String Course;
    public int number;
    public Student()
    {
        name = "Yusuf";
        age = 21;
        rollnum = 6;
        Course = "CSE";
        number = 12345;
    }
    public Student(String name, int age, int rollnum, String Course, int number)
    {
        this.name = name;
        this.age = age;
        this.rollnum = rollnum;
        this.Course = Course;
        this.number = number;
    }
    public void show()
    {

        System.Console.WriteLine("Name:" + name);
        System.Console.WriteLine("Age:" + age);
        System.Console.WriteLine("RollNum:" + rollnum);
        System.Console.WriteLine("Course:" + Course);
        System.Console.WriteLine("numbers:" + number);
    }

    public void msg()
    {
        System.Console.WriteLine("Hello I am a student");

    }

}

public class Length
{
    public Length(int num)
    {
        int count = 0;
        while (num != 0)
        {
            num /= 10;
            count++;
        }
        Console.WriteLine("Number of digits:"+count);
    }

    public Length(string text)
    {
        Console.WriteLine("Number of characters:"+text.Length);
    }
}
