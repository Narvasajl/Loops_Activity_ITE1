using System;

class Program
{
     static void Main()
    {
        //Practice set - Sum of Odd Digits
       
        int num = 1357911;
        int sum = 0;
        
        while (num != 0) {
            int digit = num % 10;
            if (digit % 2 != 0) {
                sum += digit;
            }
            num /= 10;
        }
        Console.WriteLine("Sum of odd digits: " + sum);
    }
}