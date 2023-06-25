using System;

class Program
{
    static void Main()
    {
        char choice;

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("a. Convert Binary to Decimal");
            Console.WriteLine("b. Convert Decimal to Binary");
            Console.WriteLine("c. Convert Hexadecimal to Octal");
            Console.WriteLine("d. Convert Octal to Decimal");
            Console.WriteLine("e. Exit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (choice)
            {
                case 'a':
                    Console.Write("Enter a binary number: ");
                    string binary = Console.ReadLine();
                    int decimalValue = ConvertBinaryToDecimal(binary);
                    Console.WriteLine("Decimal value: " + decimalValue);
                    break;

                case 'b':
                    Console.Write("Enter a decimal number: ");
                    int decimalNumber = int.Parse(Console.ReadLine());
                    string binaryValue = ConvertDecimalToBinary(decimalNumber);
                    Console.WriteLine("Binary value: " + binaryValue);
                    break;

                case 'c':
                    Console.Write("Enter a hexadecimal number: ");
                    string hexadecimal = Console.ReadLine();
                    string octalValue = ConvertHexadecimalToOctal(hexadecimal);
                    Console.WriteLine("Octal value: " + octalValue);
                    break;

                case 'd':
                    Console.Write("Enter an octal number: ");
                    string octal = Console.ReadLine();
                    int decimalOctalValue = ConvertOctalToDecimal(octal);
                    Console.WriteLine("Decimal value: " + decimalOctalValue);
                    break;

                case 'e':
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        } while (choice != 'e');
    }

    static int ConvertBinaryToDecimal(string binary)
    {
        int decimalValue = Convert.ToInt32(binary, 2);
        return decimalValue;
    }

    static string ConvertDecimalToBinary(int decimalNumber)
    {
        string binaryValue = Convert.ToString(decimalNumber, 2);
        return binaryValue;
    }

    static string ConvertHexadecimalToOctal(string hexadecimal)
    {
        string octalValue = Convert.ToString(Convert.ToInt32(hexadecimal, 16), 8);
        return octalValue;
    }

    static int ConvertOctalToDecimal(string octal)
    {
        int decimalValue = Convert.ToInt32(octal, 8);
        return decimalValue;
    }
}
