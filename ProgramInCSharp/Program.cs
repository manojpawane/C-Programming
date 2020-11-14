using ProgramInCSharp;
using System;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Hello workd");
        int ch = 0;
        do
        {
            Console.WriteLine("1. Exit");
            Console.WriteLine("2. Positive and Negative number");
            Console.WriteLine("3. Even and Odd number");
            Console.WriteLine("4. Sum of first N natural numbers");
            Console.WriteLine("5. Sum of Number in range");
            Console.WriteLine("6. Greatest of two numbers");
            Console.WriteLine("7. Greatest of Three numbers");
            Console.WriteLine("8. Prime number");
            Console.WriteLine("9. Prime Number in range..");
            Console.WriteLine("10. Sum of Digits..");
            Console.WriteLine("11. Reverse of Number.");
            Console.WriteLine("12. Palindrome checker..");
            Console.WriteLine("13. Check Palindrome for number.");
            Console.WriteLine("14. Armstrong Number..");
            Console.WriteLine("15. Armstrong Number within range..");
            Console.WriteLine("16. Fibonacci Series..");
            Console.WriteLine("17. Factors of Number.");
            ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 2:Utility.PostiveAndNegativeNumber();
                        break;
                case 3:
                    Utility.EvenOddNumber();
                    break;
                case 4:
                    Utility.SumOfFirstNNaturalNumber();
                    break;
                case 5:
                    Utility.SumOfNumbersInRange();
                    break;
                case 6:
                    Utility.GreatestOfTwoNumber();
                    break;
                case 7:Utility.GreatestOfThreeNumber();
                    break;
                case 8: Utility.PrimeNumber();
                    break;
                case 9:Utility.PrimeNumberInRange();
                    break;
                case 10: Utility.SumOfDigitsOfANumber();
                    break;
                case 11: Utility.ReverseOfANumber();
                    break;
                case 12:Utility.CheckPalindrome();
                    break;
                case 13: Utility.CheckPalindromeForNumber();
                    break;
                case 14: Utility.ArmstrongNumber();
                    break;
                case 15: Utility.ArmstrongNumberWithinRange();
                    break;
                case 16: Utility.FibonacciSeries();
                    break;
                case 17:Utility.FactorialOfNumber();
                    break;
            }
        }
        while (ch != 1 );
    }
}