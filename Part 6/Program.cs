using System;

namespace Part_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            
            do
            {
                Console.WriteLine("Loop Practice");
                Console.WriteLine("");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1 - For Question 1");
                Console.WriteLine("2 - For Question 2");
                Console.WriteLine("3 - For Question 3");
                Console.WriteLine("4 - For Question 4");
                Console.WriteLine("5 - For Question 5");
                Console.WriteLine("6 - For Question 6");
                Console.WriteLine("7 - While Loop Question 1");
                Console.WriteLine("8 - While Loop Question 2");
                Console.WriteLine("10 - QUIT");
                while (!Int32.TryParse(Console.ReadLine(), out choice))
                    Console.WriteLine("Invalid selection, try again.");

                Console.WriteLine("");
                Console.WriteLine("");
                switch (choice)
                {
                    case 1:
                        ForQuestion1();
                        break;
                    case 2:
                        ForQuestion2Sol1();
                        break;
                    case 3:
                        ForQuestion3();
                        break;
                    case 4:
                        ForQuestion4();
                        break;
                    case 5:
                        ForQuestion5();
                        break;
                    case 6:
                        ForQuestion6();
                        break;
                    case 7:
                        WhileQuestion1();
                        break;
                    case 8:
                        WhileQuestion2();
                        break;
                    case 10:
                        Console.WriteLine("Thanks for participating");
                        break;
                    default:    
                        Console.WriteLine("Wrong Choice");
                        break;
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            } while (choice != 10);
        }

        public static void ForQuestion1()
        {
            Console.WriteLine("Question 1");
            Console.WriteLine("");
            for (int a = 1; a <= 10; a++)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine("");
        }

        public static void ForQuestion2Sol1()
        {
            Console.WriteLine("Question 2 Solution 1");
            Console.WriteLine("");
            for (int b = 5; b <= 55; b += 5)
            {
                Console.WriteLine(b);
            }
        }

        public static void ForQuestion2Sol2()
        {
            Console.WriteLine("Question 2 Solution 2");
            Console.WriteLine("");
            for (int c = 1; c <= 11; c++)  
            {
                Console.WriteLine(c * 5);
            }
        }

        public static void ForQuestion3()
        {
            Console.WriteLine("Question 3");
            Console.WriteLine("");
            for (int d = 99; d >= 55; d--)
            {
                Console.WriteLine(d);
            }
        }

        public static void ForQuestion4()
        {
            int evenSum = 0;
            int oddSum = 0;
            Console.WriteLine("Question 4");
            Console.WriteLine("");
            for (int e = 20; e <= 40; e++)
            {
                if (e % 2 == 0) 
                {
                    evenSum += e;
                }
                else  
                {
                    oddSum += e;
                }
            }
            Console.WriteLine($"Sum of odd numbers: {oddSum}");
            Console.WriteLine($"Sum of even numbers: {evenSum}");
        }
        public static void ForQuestion5()
        {
            
            int factorial = 1;
            for (int f = 5; f >= 1; f--)
            {
                factorial *= f;
            }
            Console.WriteLine($"5! = {factorial}");
        }

        public static void ForQuestion6()
        {
            int numEven = 0;
            int input;
            Console.WriteLine("Enter 5 integers, i'll tell you how many are even");
            for (int g = 0; g < 5; g++)
            {
                Console.WriteLine("Please enter an integer:");
                while (!Int32.TryParse(Console.ReadLine(), out input))
                    Console.WriteLine("Invalid integer:");
                if (input % 2 == 0) 
                    numEven += 1;
            }
            Console.WriteLine($"You entered {numEven}");
        }

        public static void WhileQuestion1()
        {
            int selection;
            Console.WriteLine("Select your favourite character:");
            do
            {
                Console.WriteLine("1 - Arthur Morgan");
                Console.WriteLine("2 - Mario");
                Console.WriteLine("3 - Frank Woods");
                Console.WriteLine("4 - Donatello");
                while (!Int32.TryParse(Console.ReadLine(), out selection))
                    Console.WriteLine("Invalid input, enter an integer:");
                if (selection != 4)
                {
                    Console.WriteLine("Good choice, but Try again");
                    Console.WriteLine("");
                }

            } while (selection != 4);
            Console.WriteLine("Good Choice.");
        }

        public static void WhileQuestion2()
        {
            int age;
            Console.WriteLine("Please enter your age:");
            while (!Int32.TryParse(Console.ReadLine(), out age) || age <= 0)
                Console.WriteLine("Try again:");
            Console.WriteLine("Thanks");
        }
    }
}
