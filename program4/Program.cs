using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string vowels = FindVowels(input);

        Console.WriteLine("Vowels in the string: " + vowels);
    }

    static string FindVowels(string input)
    {
        string vowels = "";

        input = input.ToLower(); // Convert the input string to lowercase for case-insensitive comparison

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];

            if (IsVowel(currentChar))
            {
                vowels += currentChar;
            }
        }

        return vowels;
    }

    static bool IsVowel(char c)
    {
        // Check if the character is a vowel (case-insensitive)
        return "aeiou".IndexOf(char.ToLower(c)) != -1;
    }
}
