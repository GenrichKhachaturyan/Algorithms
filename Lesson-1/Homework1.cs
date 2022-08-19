using System;

namespace Homework1
{
    public class Homework1
    {
        public static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("===================== Homework №1 =====================");
                Console.WriteLine("1 - Task №1 Напишите на C# функцию согласно блок-схеме");
                Console.WriteLine("2 - Task №2 Посчитайте сложность функции");
                Console.WriteLine("3 - Task №3 Реализуйте функцию вычисления числа Фибоначчи\n");
                Console.WriteLine("0 - Terminating processes\n");
                Console.WriteLine("=======================================================");
                Console.Write("Enter task number: ");

                if (int.TryParse(Console.ReadLine(), out int numTask))
                {
                    switch (numTask)
                    {
                        case 0:
                            Console.Write("terminating processes...");
                            return;
                        case 1:
                            SimpleNum();
                            break;
                        case 2:
                            Console.WriteLine("\nO(N^3)\nSee code programm");
                            break;
                        case 3:
                            Console.Clear();
                            bool whil = true;

                            while (whil)
                            {
                                Console.Write("=====choose a Fibonacci solution=====\n");
                                Console.WriteLine("1 - Cycle");
                                Console.WriteLine("2 - Recursion\n");
                                Console.WriteLine("0 - Exit on menu");
                                Console.WriteLine("======================================");
                                Console.Write("Enter number solution: ");
                                if (int.TryParse(Console.ReadLine(), out int numChoose))
                                {
                                    switch (numChoose)
                                    {
                                        case 0:
                                            whil = false;
                                            break;
                                            
                                        case 1:

                                            Console.Write("Enter num Fibonacci: ");
                                            if(int.TryParse(Console.ReadLine(),out int number))
                                            {
                                                try
                                                {
                                                    int numFib = FibonacciCycle(number);
                                                    Console.WriteLine($"Number Fibonacci: {numFib}");
                                                }
                                                catch(Exception exp)
                                                {
                                                    Console.WriteLine(exp.Message);
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Incorrect value entered!");
                                            }
                                            Console.ReadKey(true);
                                            Console.Clear();
                                            break;
                                        case 2:
                                            Console.Write("Enter num Fibonacci: ");
                                            if (int.TryParse(Console.ReadLine(), out int num))
                                            {
                                                try
                                                {
                                                    int numFib = FibonacciRecursion(num);
                                                    Console.WriteLine($"Number Fibonacci: {numFib}");
                                                }
                                                catch (Exception exp)
                                                {
                                                    Console.WriteLine(exp.Message);
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Incorrect value entered!");
                                            }
                                            Console.ReadKey(true);
                                            Console.Clear();
                                            break;
                                    }
                     
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect value entered!");
                                    Console.ReadKey(true);
                                    Console.Clear();
                                }
                            }

                            break;
                        default:
                            Console.WriteLine("You entered an invalid number!");
                            break;
                    }
                }
                else
                    Console.WriteLine("Incorrect value entered!");
                    Console.ReadKey(true);
                    Console.Clear();
            }
        }

        /// <summary>
        /// Задание №1
        /// Напишите на C# функцию согласно блок-схеме
        /// </summary>
        static void SimpleNum()
        {

            bool somevalue = true;
            Console.Write("Enter number: ");
            int.TryParse(Console.ReadLine(), out int number);

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    somevalue = false;
                    break;
                }
            }
            if (somevalue)
                Console.WriteLine("Prime number! ");
            else
                Console.WriteLine("Not a prime number! ");
        }


        /// <summary>
        /// Задание №2
        /// Посчитайте сложность функции
        /// </summary>
        static void CalFunComplexity(int[] inputArray)
        {
            int sum = 0; //O(1)
            for (int i = 0; i < inputArray.Length; i++)//O(N)
            {
                for (int j = 0; j < inputArray.Length; j++)//O(N^2)
                {
                    for (int k = 0; k < inputArray.Length; k++)//O(N^3)
                    {
                        int y = 0;
                        if (j != 0)
                        {
                            y = k / j;
                        }
                        sum += inputArray[i] + i + k + j + y;
                    }
                }
            }//Ответ O(N * N * N)= O(N^3)
           
        }
        /// <summary>
        /// Задание №3
        /// Реализуйте функцию вычисления числа Фибоначчи
        /// </summary>
        static int FibonacciRecursion(int n)
        {
            if (n < 0)
                throw new Exception("number less than 0");

            if (n == 0 || n == 1)
                return n;
            return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
                
        }


        /// <summary>
        /// Задание №3.1
        /// Реализуйте функцию вычисления числа Фибоначчи
        /// </summary>
        static int FibonacciCycle(int n)
        {
            if (n < 0)
                throw new Exception("number less than 0");

            int a = 0;
            int b = 1;
            int sum;

            for (int i = 0; i < n; i++)
            {
                sum = a;
                a = b;
                b += sum;
            }

            return a;
        }

    }

}

