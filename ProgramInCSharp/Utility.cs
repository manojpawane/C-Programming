using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramInCSharp
{
    public class Utility
    {
        public static void PostiveAndNegativeNumber()
        {
            int a = 5;
            if(a> 0)
            {
                Console.WriteLine("Postive Number");
            }
            else
            {
                Console.WriteLine("Negative Number");
            }
        }

        public static void EvenOddNumber()
        {
            int a = 5;
            if(a % 2 == 0)
            {
                Console.WriteLine("Number is even Number");
            }
            else
            {
                Console.WriteLine("Number is odd number");
            }
        }

        public static void SumOfFirstNNaturalNumber()
        {
            int a = 10;
            int sum = 0;
            for(int i = 1; i<=a; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum of N natural number are: {0}", sum);
        }

        public static void SumOfNumbersInRange()
        {
            int start = 4;
            int end = 20;
            int sum = 0;
            for(int i = start; i <=end; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of numbers in range:{0} ", sum);
        }

        public static void GreatestOfTwoNumber()
        {
            int a = 5;
            int b = 10;
            if(a > b)
            {
                Console.WriteLine("Greatest Number:{0}",a);
            }
            else
            {
                Console.WriteLine("Greatest Number: {0}", b);
            }
        }

        public static void GreatestOfThreeNumber()
        {
            int a = 5;
            int b = 7;
            int c = 10;
            if(a > b && a > c)
            {
                Console.WriteLine(a+" is greatest number..");
            }
            else if(b > a && b > c)
            {
                Console.WriteLine(b+ " is greatest number..");
            }
            else if(c > b && c > a)
            {
                Console.WriteLine(c+ " is greatest number..");
            }
            else
            {
                Console.WriteLine("All numbers are same..");
            }
        }

        public static void LeapYear()
        {
            int year = 3000;
            if(year % 4 ==0 && year%100 != 0 || year % 400 ==0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("Not a Leap year..");
            }
        }

        public static void PrimeNumber()
        {
            int a = 5;
            for(int i = 2; i < a; i++)
            {
                if(a % i ==0)
                {
                    Console.WriteLine("Number is not prime");
                    return;
                }
            }
            Console.WriteLine("Number is prime..");
        }

        public static void PrimeNumberInRange()
        {
            int lowRange = 2;
            int highRange = 100;
            int flag = 0;
            for (int i = lowRange; i < highRange; i++)
            {
                flag = 0;
                for (int j = 2; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if(flag != 1)
                {
                    Console.WriteLine(i+" ");
                }
            }
        }

        public static void SumOfDigitsOfANumber()
        {
            int number = 12345;
            int sum = 0;
            while(number != 0 )
            {
                int temp = number % 10;
                sum = sum + temp;
                number = number / 10;
            }
            Console.WriteLine("Sum of Digits: "+sum);
        }

        public static void ReverseOfANumber()
        {
            int number = 12345;
            int temp = 0;
            int temp2 = 0;
            while(number != 0)
            {
                temp2 = number % 10;
                temp = temp * 10 + temp2;
                number = number / 10;
            }

            Console.WriteLine(temp);
        }

        public static void CheckPalindrome()
        {
            string st = "Madama";
            string st1 = "";
            int length = st.Length-1;
            for(int i = length; i >= 0; i--)
            {
                st1 = st1 + st[i];
            }
            if(String.Equals(st, st1, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("String are palindrome..");
            }
            else
            {
                Console.WriteLine("Strings are not palindrome");
            }
        }

        public static void CheckPalindromeForNumber()
        {
            long st = 121;
            long temp = 0;
            long temp2 = 0;
            long duplicate = st;
            while(st!=0)
            {
                temp = st % 10;
                temp2 = temp2 * 10 + temp;
                st = st / 10;
            }
            if(temp2 == duplicate)
            {
                Console.WriteLine("Palindrome..");
            }
            else
            {
                Console.WriteLine("Number is not palindrome..");
            }
        }

        public static void ArmstrongNumber()
        {
            int a = 407;
            int cubeValue = 0;
            int duplicateNumber = a;
            int temp = 0;
            while(a != 0)
            {
                temp = a % 10;
                cubeValue = cubeValue + (int)Math.Pow(temp, 3);
                a = a / 10;
            }
            if(cubeValue == duplicateNumber)
            {
                Console.WriteLine("Armstrong Number..");
            }
            else
            {
                Console.WriteLine("Not Armstrong Number");
            }
        }

        public static void ArmstrongNumberWithinRange()
        {
            int startRange = 10;
            int endingRange = 1000;
            for(int i =startRange; i < endingRange; i ++)
            {
                int cubeValue = 0;
                int tempDuplicate = i;
                int temp = 0;
                while (tempDuplicate != 0)
                {
                    temp = tempDuplicate % 10;
                    cubeValue += (int)Math.Pow(temp, 3);
                    tempDuplicate /= 10;
                }
                if (cubeValue == i)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void FibonacciSeries()
        {
            int limit = 10;
            int z = 1;
            int initial = 0;
            int currentValue = 0;
            while(currentValue < limit)
            {
                if(currentValue <= 1)
                {
                    Console.WriteLine(currentValue);
                }
                else
                {
                    currentValue = initial + z;
                    Console.WriteLine(currentValue + " ");
                    initial = z;
                    z = currentValue;
                }

            }
        }

        public static int FactorialOfNumber(int number)
        {
            int factorialOfNumber = 1;
            for(int i = 1; i <=number; i++)
            {
                factorialOfNumber = factorialOfNumber * i;
            }
            Console.WriteLine(factorialOfNumber);
            return factorialOfNumber;
        }

        public static void FactorsOfNumber()
        {
            int number = 16;
            for(int i = 2; i <= number/2; i++)
            {
                if(number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void StrongNumber()
        {
            int checkNumber = 146;
            int duplicateNumber = checkNumber;
            int temp = 0;
            int sumOfFactorial = 0;
            while(checkNumber != 0)
            {
                temp = checkNumber % 10;
                sumOfFactorial = sumOfFactorial + (FactorialOfNumber(temp));
                checkNumber = checkNumber / 10;
            }

            if (sumOfFactorial == duplicateNumber)
            {
                Console.WriteLine("Strong Number.");
            }
            else
            {
                Console.WriteLine("Not a strong number.");
            }
        }

        public static void PoweroFNumber()
        {
            int baseValue = 3;
            int exponenet = 3;
            int result = 1;
            while(exponenet !=0)
            {
                result = result * baseValue;
                exponenet--;
            }
            Console.WriteLine("Power of Number: "+result);
        }

        public static void PerfectNumber()
        {
            int number = 28;
            int sum = 0;
            for(int i = 1; i <= number/2; i++)
            {
                if(number % i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(sum);
            if (sum == number)
            {
                
                Console.WriteLine("number is perfect number.");
            }
            else
            {
                Console.WriteLine("Number is not a perfect number..");
            }   
        }

        public static void AuthomorphicNumber()
        {
            int number = 75;
            int sqOfNumber = number * number;
            int flag = 0;
            while(number != 0)
            {
                if(number % 10 != sqOfNumber % 10)
                {
                    flag = 1;
                    break;
                }
                number = number / 10;
                sqOfNumber = sqOfNumber / 10;
            }
            if (flag == 0)
            {
                Console.WriteLine("Automorphic Number..");
            }
            else
            {
                Console.WriteLine("Not a Automorphic Number..");
            }
        }

        public static void HarshadNumber()
        {
            int number = 19;
            int temp = 0;
            int sum = 0;
            int duplicateNumber = number;
            while(number != 0)
            {
                temp = number % 10;
                sum = sum + temp;
                number = number / 10;
            }
            if(duplicateNumber % sum == 0)
            {
                Console.WriteLine("Harshad Number..");
            }
            else
            {
                Console.WriteLine("not a Harshad Number..");
            }
        }

        public static void AbdundantNumber()
        {
            int number = 12;
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine(i);
                }
            }

            if(sum > number)
            {
                Console.WriteLine("Abdundant Number..");
            }
            else
            {
                Console.WriteLine("Not an Abduntant Number..");
            }
        }

        public static int FactorOfNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }

        public static void FriendlyPair()
        {
            int num = 221;
            int num2 = 284;

            int sumOfNum = FactorOfNumber(num);
            int sumOfNum2 = FactorOfNumber(num2);
            if(sumOfNum == num2 && sumOfNum2 == num)
            {
                Console.WriteLine("Friendly pair..");
            }
            else
            {
                Console.WriteLine("Not a friendly pair..");
            }
        }
    }
}
