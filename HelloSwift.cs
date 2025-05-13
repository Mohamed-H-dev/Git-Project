using System;

class MyClass
{
    // This is a comment
    public int MyProperty { get; set; }
    public MyClass()
    {
        MyProperty = 42;
    }
    public void MyMethod()
    {
        Console.WriteLine("Hello from MyClass");
    }
    public int MyMethodWithReturn()
    {
        return MyProperty;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello From Class 1");

	 Console.WriteLine("Hello From GIT 2 MH");

        Console.Writeline("Form Ali-branch");
    }
}