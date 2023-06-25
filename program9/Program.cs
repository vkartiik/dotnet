using System;

class MultiplyNumbers
{
    private int value1;
    private int value2;

    public MultiplyNumbers(int num1, int num2)
    {
        value1 = num1;
        value2 = num2;
    }

    public int Multiply()
    {
        return value1 * value2;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        MultiplyNumbers multiplier = new MultiplyNumbers(num1, num2);
        int result = multiplier.Multiply();

        Console.WriteLine("Multiplication result: " + result);
    }
}
