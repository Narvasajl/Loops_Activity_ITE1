using System;

class Program
{
     static void Main()
    {
        //Practice set - Sum of Square
       
        int sum = 0;
        for (int i = 1; i <= 10; i++) {
            sum += i * i;  
        }
        Console.WriteLine("Sum of squares of first 10 natural numbers is: " + sum);
    }
}