using System;

class chk
{
    public int a { get; set; }
    public int b { get; set; }
    public int sum
    {
        get
        {
            return a + b;
        }
    }
    class Test
    {
        static void Main()
        {
            chk c = new chk();
            c.a = 10;
            c.b = 5;
            Console.WriteLine(c.sum);
            Console.ReadKey();
        }
    }
}