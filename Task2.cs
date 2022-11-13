using System;
/*Write a program in c# to create a function to calculate the sum of the individual digits of 
a given number*/
//1234
//10
class Task2
{
    static void Main(string[] args)
    {
        /*Write a program in c# to create a function to calculate the sum of the individual
         digits of a given number*/

        Console.WriteLine("Enter a number");
        try
        {
            string str = Console.ReadLine();
            // Creating an integer array 
            int[] num = new int[str.Length];
            // Copy character by character into array 
            for (int i = 0; i < str.Length; i++)
            {
                num[i] = Convert.ToInt32("" + str[i]);
            }
            SumOfDigit(num);
        }
        catch (Exception)
        {
            Console.WriteLine("Plz enter number only...");
        }

        static void SumOfDigit(int[] num)
        {
            int sumOfDigit = 0;

            for (int i = 0; i < num.Length; i++)
            {
                sumOfDigit += num[i];
            }
            Console.WriteLine(sumOfDigit);
        }


    }
}