using System;

class Program
{
     static void Main()
    {
        //Practice set - Power of a Number 
       
        Console.Write("Enter base number: ");
        int basenum = int.Parse(Console.ReadLine());

        Console.Write("Enter exponent: ");
        int exponent = int.Parse(Console.ReadLine());

        int result = 1;

        for (int i = 1; i <= exponent; i++) {
            result *= basenum;
        }

        Console.WriteLine($"{basenum} ^ {exponent} = {result}");
    }
}