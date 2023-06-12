
﻿using System;

namespace ConsoleApp4
{
    class Program
    {
         static void StartSequence()
        {
            try
            {
                Console.WriteLine("Please enter a number greater than zero");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[size];
                arr = Populate(arr);
                int sum = GetSum(arr);
                int product = GetProduct(arr, sum);
                decimal quotient = GetQuotient(product);

                Console.WriteLine($"Your array is size: {arr.Length}");
                Console.WriteLine($"The numbers in the array are {string.Join(',', arr)}");
                Console.WriteLine($"The sum of the array is {sum}");
                int chosenNumber = product / sum;
                Console.WriteLine($"{sum} * {chosenNumber} = {product}");
                decimal div = product / quotient;
                Console.WriteLine($"{product} / {div} =  {quotient}");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

                  }
        static  int [] Populate(int []arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Please enter number: " + (i + 1) + " of " + arr.Length);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            GetSum(arr);
            return arr;

        }
        //get sum
        static int GetSum(int [] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            if (sum < 20)
            {
                throw new Exception($"Value of {sum} is too low");
            }
           
            return sum;
        }
        static int GetProduct(int[] arr, int sum)
        {
            try
            {
                Console.WriteLine("Please select a random number between 1 to" + arr.Length);
                int number = Convert.ToInt32(Console.ReadLine());
               

                int product = sum * arr[number];


              
                return product;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range " + ex.Message);
                throw new IndexOutOfRangeException("Index out of range");
            }
        }
        static decimal GetQuotient(int prod)
        {
            try
            {
                Console.WriteLine("Please enter a number to divide your product " + prod + " by:");
                int number2 = Convert.ToInt32(Console.ReadLine());
                decimal quotient = decimal.Divide(prod, number2);
                return quotient;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divided by Zero exeption" + ex.Message);
                return 0;
            }
        }
       
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to my game! Let's do some math!");
                StartSequence();
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception in Main has been caught");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Program is complete.");
            }
        }
    }
}

