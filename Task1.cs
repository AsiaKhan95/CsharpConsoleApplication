using System;
//Task 1
//Write a program in C# to creaet a function to check whether a number is prime or not
//prime no : number that is only divisible by itself
class Task1
{
    static void Main(string[] args)
    {

        int PrimeNumberChecker(int num)
        {
            int noOfFactor = 0;
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    noOfFactor++;
                }
            }
            return noOfFactor;
        }

        Console.WriteLine("Enter a number");
        try
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int noOfFactor = PrimeNumberChecker(num);
            if (noOfFactor == 1)
            {
                Console.WriteLine($"{num} is a prime number");
            }
            else
            {
                Console.WriteLine($"{num} is a not prime number");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Please enter a number {e}");
        }
    }
}
