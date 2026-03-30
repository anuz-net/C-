
using System;
class Student
{
    public int id, age;
    public string name, subject;
    public Student(int id, String name, int age, String subject)
    {
        this.id = id;
        this.name = name;
        this.age = age;
        this.subject = subject;
    }
    public void display()
    {
        Console.WriteLine(id + " " + name + " " + age + " " + subject);
    }
}
class StudentDetails
{
    public static void Main()
    {
        Student s1 = new Student(101, "Sonoo", 23, "java");
        Student s2 = new Student(102, "Ravi", 25, "python");
        s1.display();
        s2.display();
    }
}