using System;

class ComplexNumber
{
    private double real;
    private double imaginary;

    public ComplexNumber(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
    {
        double realSum = c1.real + c2.real;
        double imaginarySum = c1.imaginary + c2.imaginary;
        return new ComplexNumber(realSum, imaginarySum);
    }

    public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
    {
        double realDiff = c1.real - c2.real;
        double imaginaryDiff = c1.imaginary - c2.imaginary;
        return new ComplexNumber(realDiff, imaginaryDiff);
    }

    public override string ToString()
    {
        return "(" + real + " + " + imaginary + "i)";
    }
}

class Program
{
    static void Main()
    {
        ComplexNumber complex1 = new ComplexNumber(2, 3);
        ComplexNumber complex2 = new ComplexNumber(1, 2);

        ComplexNumber sum = complex1 + complex2;
        ComplexNumber difference = complex1 - complex2;

        Console.WriteLine("Complex1: " + complex1);
        Console.WriteLine("Complex2: " + complex2);
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Difference: " + difference);
    }
}
