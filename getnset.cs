using System;
class MyClass
{
    private int x;
    public void setx(int i)
    {
        x = i;
    }
    public int getx()
    {
        return x;
    }
}
class Client
{
    public static void Main(string[] args)
    {
        MyClass ob = new MyClass();
        ob.setx(10);
        int val = ob.getx();
        Console.WriteLine(ob.getx());
    }
}