using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramInCSharp
{
    public class Utility
    {
        public static void PostiveAndNegativeNumber()
        {
            int a = 5;
            if (a > 0)
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
            if (a % 2 == 0)
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
            for (int i = 1; i <= a; i++)
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
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of numbers in range:{0} ", sum);
        }

        public static void GreatestOfTwoNumber()
        {
            int a = 5;
            int b = 10;
            if (a > b)
            {
                Console.WriteLine("Greatest Number:{0}", a);
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
            if (a > b && a > c)
            {
                Console.WriteLine(a + " is greatest number..");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b + " is greatest number..");
            }
            else if (c > b && c > a)
            {
                Console.WriteLine(c + " is greatest number..");
            }
            else
            {
                Console.WriteLine("All numbers are same..");
            }
        }

        public static void LeapYear()
        {
            int year = 3000;
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
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
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
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
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag != 1)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }

        public static void SumOfDigitsOfANumber()
        {
            int number = 12345;
            int sum = 0;
            while (number != 0)
            {
                int temp = number % 10;
                sum = sum + temp;
                number = number / 10;
            }
            Console.WriteLine("Sum of Digits: " + sum);
        }

        public static void ReverseOfANumber()
        {
            int number = 12345;
            int temp = 0;
            int temp2 = 0;
            while (number != 0)
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
            int length = st.Length - 1;
            for (int i = length; i >= 0; i--)
            {
                st1 = st1 + st[i];
            }
            if (String.Equals(st, st1, StringComparison.OrdinalIgnoreCase))
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
            while (st != 0)
            {
                temp = st % 10;
                temp2 = temp2 * 10 + temp;
                st = st / 10;
            }
            if (temp2 == duplicate)
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
            while (a != 0)
            {
                temp = a % 10;
                cubeValue = cubeValue + (int)Math.Pow(temp, 3);
                a = a / 10;
            }
            if (cubeValue == duplicateNumber)
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
            for (int i = startRange; i < endingRange; i++)
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
            while (currentValue < limit)
            {
                if (currentValue <= 1)
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
            for (int i = 1; i <= number; i++)
            {
                factorialOfNumber = factorialOfNumber * i;
            }
            Console.WriteLine(factorialOfNumber);
            return factorialOfNumber;
        }

        public static void FactorsOfNumber()
        {
            int number = 16;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
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
            while (checkNumber != 0)
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
            while (exponenet != 0)
            {
                result = result * baseValue;
                exponenet--;
            }
            Console.WriteLine("Power of Number: " + result);
        }

        public static void PerfectNumber()
        {
            int number = 28;
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
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
            while (number != 0)
            {
                if (number % 10 != sqOfNumber % 10)
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
            while (number != 0)
            {
                temp = number % 10;
                sum = sum + temp;
                number = number / 10;
            }
            if (duplicateNumber % sum == 0)
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

            if (sum > number)
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
            if (sumOfNum == num2 && sumOfNum2 == num)
            {
                Console.WriteLine("Friendly pair..");
            }
            else
            {
                Console.WriteLine("Not a friendly pair..");
            }
        }

        public static void GcdOrHcf()
        {
            int n = 1;
            int num1 = 10;
            int num2 = 15;
            if (num1 != num2)
            {
                while (n != 0)
                {
                    n = num1 % num2;
                    if (n != 0)
                    {
                        num1 = num2;
                        num2 = n;
                    }
                }
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine("Wrong input..");
            }
        }

        public static void EuclideanAlgorithm(int a, int b)
        {
            if (a == 0)
            {
                Console.WriteLine(b); ;
            }
            else
            {
                EuclideanAlgorithm(b % a, a);
            }
        }


        public static void Lcm(int first, int second, int fact)
        {
            if (fact % first == 0 && fact % second == 0)
            {
                Console.WriteLine(fact);
            }
            else
            {
                fact = fact + first;
                Lcm(first, second, fact);
            }

        }

        public static void LcmFor(int first, int second)
        {
            Lcm(first, second, first);
        }

        public static void BinaryToDecimal()
        {
            long n = 10110;
            int i = 0;
            int decimalNum = 0;
            int rem = 0;
            int res = 0;
            while (n != 0)
            {
                rem = (int)n % 10;
                res = (int)(rem * Math.Pow(2, i));
                i++;
                decimalNum = decimalNum + res;
                n = n / 10;
            }
            Console.WriteLine(decimalNum);
        }

        public static void BinaryToOctal()
        {
            long n = 10110;
            int i = 0;
            int decimalNum = 0;
            int rem = 0;
            int res = 0;
            while (n != 0)
            {
                rem = (int)n % 10;
                res = (int)(rem * Math.Pow(2, i));
                i++;
                decimalNum = decimalNum + res;
                n = n / 10;
            }

            i = 1;

            int octal = 0;
            rem = 0;
            while (decimalNum != 0)
            {
                rem = decimalNum % 8;
                octal = octal + (rem * i);
                i = i * 10;
                decimalNum = decimalNum / 8;
            }

            Console.WriteLine(octal);
        }

        public static void DecimalToBinary()
        {
            int num = 155;
            int rem = 0;
            int i = 1;
            long Binary = 0;
            while (num != 0)
            {
                rem = num % 2;
                Binary = Binary + (rem * i);
                i = i * 10;
                num = num / 2;
            }
            Console.WriteLine(Binary);
        }

        public static void DecimalToOctal()
        {
            int num = 717;
            int rem = 0;
            int octal = 0;
            int i = 1;
            while (num != 0)
            {
                rem = num % 8;
                octal = octal + (rem * i);
                i = i * 10;
                num = num / 8;
            }
            Console.WriteLine(octal);
        }

        public static void OctalToBinary()
        {
            int num = 26;
            int rem = 0;
            int temp = 0;
            int i = 0;
            int decimalNumber = 0;
            while (num != 0)
            {
                rem = num % 10;
                temp = rem * (int)(Math.Pow(8, i));
                i++;
                decimalNumber = decimalNumber + temp;
                num = num / 10;
            }
            i = 1;
            int remForDec = 0;
            long binaryNumber = 0;
            while (decimalNumber != 0)
            {
                remForDec = decimalNumber % 2;
                binaryNumber = binaryNumber + (remForDec * i);
                i = i * 10;
                decimalNumber = decimalNumber / 2;
            }
            Console.WriteLine(binaryNumber);
        }

        public static void OctalToDecimail()
        {
            int num = 2012;
            int rem = 0;
            int temp = 0;
            int i = 0;
            int sum = 0;
            while (num != 0)
            {
                rem = num % 10;
                temp = rem * (int)Math.Pow(8, i);
                i++;
                sum = sum + temp;
                num = num / 10;
            }
            Console.WriteLine(sum);
        }

        public static void QuadrantInCoordinates()
        {
            int x = 5;
            int y = 10;
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Quadrant 1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Quadrant 2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Quadrant 3");
            }
            else if (x == 0)
            {
                Console.WriteLine("Lies on Y cordinate");
            }
            else if (y == 0)
            {
                Console.WriteLine("Lies on X coordinate");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Quadrant 4");
            }
            else
            {
                Console.WriteLine("Lies on origin");
            }
        }

        public static int Factorial(int number)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public static void PermutationInClassroom()
        {
            int numberOfStudents = 6;
            int numberOfSeats = 5;
            int ways = Factorial(numberOfStudents) / Factorial(numberOfStudents - numberOfSeats);
            Console.WriteLine(ways);
        }

        public static void HandShakeProgram()
        {
            int numberOfPeople = 15;
            int numberOfHandShakes = (numberOfPeople * (numberOfPeople - 1)) / 2;
            Console.WriteLine(numberOfHandShakes);
        }

        public static void AdditionOfTwoFraction()
        {
            int num1 = 9;
            int den1 = 7;
            int num2 = 5;
            int den2 = 8;

            int num3 = (num1 * den2) + (num2 * den1);
            int den3 = den1 * den2;
            int x = 0;
            if (num3 > den3)
            {
                x = num3;
            }
            else
            {
                x = den3;
            }

            for (int i = 1; i < x; i++)
            {
                if (num3 % i == 0 && den3 % i == 0)
                {
                    num3 = num3 / i;
                    den3 = den3 / i;
                }
            }

            int n = 1;
            int p = num3;
            int q = den3;
            if (num3 != den3)
            {
                while (n != 0)
                {
                    //storing remainder
                    n = num3 % den3;
                    if (n != 0)
                    {
                        num3 = den3;
                        den3 = n;
                    }
                }
            }
            Console.WriteLine("(" + p / den3 + " / " + q / den3 + ")");
        }

        public static void Replace0With1()
        {
            int num = 5002;
            int newNum = 0;
            int n = 1;
            while (num != 0)
            {
                int rem = num % 10;
                if (rem == 0)
                {
                    rem = 1;
                }
                newNum = newNum + rem * n;
                n = n * 10;
                num = num / 10;
            }
            Console.WriteLine(newNum);
        }

        public static void Replace0With1v2()
        {
            int num = 5002;
            string newNum = num.ToString();
            string newNum2 = "";
            for (int i = 0; i < newNum.Length; i++)
            {
                if (newNum[i] == '0')
                {
                    newNum2 = newNum2 + '1';
                }
                else
                {
                    newNum2 = newNum2 + newNum[i];
                }
            }
            Console.WriteLine(newNum2);
        }

        public static bool IsPrime(int num)
        {
            int flag = 0;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                return false;
            }
            return true;
        }

        public static void ExpressedAsSumOfTwoPrimeNumber()
        {
            int number = 34;
            int div = 0;
            for (int i = 2; i <= number / 2; i++)
            {
                if (!IsPrime(i))
                {
                    if (!IsPrime(number - i))
                    {
                        Console.WriteLine(i + " + " + (number - i));
                        div++;
                    }
                }
            }
            if (div == 0)
            {
                Console.WriteLine("Number cant be expressed as Sum of Two Prime Number..");
            }
        }

        public static void CheckVowel()
        {
            char c;
            Console.WriteLine("Enter the alphabet");
            c = Convert.ToChar(Console.ReadLine());
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                Console.WriteLine("Entered value is vowel.");
            }
            else
            {
                Console.WriteLine("Entered value is consonant");
            }
        }

        public static void CharacterIsAlphabetOrNot()
        {
            Console.WriteLine("Enter the Alphabet");
            char c = Convert.ToChar(Console.ReadLine());
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                Console.WriteLine("Given character is Alphabet");
            }
            else
            {
                Console.WriteLine("Given character is not an alphabet.");
            }
        }

        public static void AreaOfCircle()
        {
            Console.WriteLine("Enter the radius to find area of circle..");
            double radius = Convert.ToDouble(Console.ReadLine());
            double pie = 3.14;
            double areaOfCircle = pie * radius * radius;
            Console.WriteLine("Area of circle is:{0} ", areaOfCircle);
        }

        public static void ASCIIValueOfCharacter()
        {
            Console.WriteLine("Enter the character.");
            char c = Convert.ToChar(Console.ReadLine());
            int i = c;
            Console.WriteLine("The ASCII value of {0} is {1}", c, i);
        }

        public static void PrimeNumberBetweenMinAndMax()
        {
            int min = 1;
            int max = 100;
            for (int i = min; i < max; i++)
            {
                int count = 0;
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintPlusAndMinus()
        {
            Console.WriteLine("Enter the value");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("-");
                }
                else
                {
                    Console.Write("+");
                }
            }
            Console.ReadLine();
        }

        public static void ReplaceStringWithUnderScore()
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            string newStr = "";
            int flag = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    flag = 1;
                    newStr = newStr + "_" + str[i];
                }
                else if (str[i] == '_')
                {
                    i++;
                    newStr = newStr + str[i].ToString().ToUpper();
                }
                else
                {
                    newStr = newStr + str[i];
                }
            }
            if (flag == 1)
            {
                Console.WriteLine(newStr.ToLower());
            }
            else
            {
                Console.WriteLine(newStr);
            }

        }

        public static void NumberOfDigitsInAnInteger()
        {
            Console.WriteLine("Enter the number.");
            long number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (number != 0)
            {
                number = number / 10;
                count++;
            }
            Console.WriteLine("The number of Digits in integer are:{0} ", count);

        }

        public static void ProgramOfNumberOfDays()
        {
            Console.WriteLine("Enter the year.");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month.");
            int month = Convert.ToInt32(Console.ReadLine());

            if (month == 2 && ((year % 4 == 0) || (year % 100 == 0) && (year % 4 == 0)))
            {
                Console.WriteLine("Number of days 29");
            }
            else if (month == 2)
            {
                Console.WriteLine("Number of days 28.");
            }
            else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 9 || month == 11)
            {
                Console.WriteLine("Number of days 30.");
            }
            else
            {
                Console.WriteLine("Number of days 31.");
            }
        }

        public static void ConvertNumberToWords()
        {
            Console.WriteLine("Incomplete program, need to work on it..");
            //char[] num = "9923".ToCharArray();
            //string[] single_digits = new string[]{ "zero", "one", "two",
            //                               "three", "four", "five",
            //                               "six", "seven", "eight",
            //                               "nine"};

            //string[] two_digits = new string[]{"", "ten", "eleven", "twelve",
            //                           "thirteen", "fourteen",
            //                           "fifteen", "sixteen", "seventeen",
            //                           "eighteen", "nineteen"};

            //string[] tens_multiple = new string[]{"", "", "twenty", "thirty",
            //                              "forty", "fifty","sixty",
            //                              "seventy", "eighty", "ninety"};

            //string[] tens_power = new string[] { "hundred", "thousand" };

            //int len = num.Length;
            //if(len == 0)
            //{
            //    Console.WriteLine("Empty string.");
            //    return;
            //}
            //if(len > 4)
            //{
            //    Console.WriteLine("Length more than 4 is not supported.");
            //    return;
            //}

            //if(len == 1)
            //{
            //    Console.WriteLine(single_digits[num[0]-'0']);
            //    return;
            //}
            //int x = 0;
            //while(x < num.Length)
            //{
            //    if(len >= 3)
            //    {
            //        if(num[x]-'0'!=0)
            //        {
            //            Console.WriteLine(single_digits[num[x]-'0'] + " ");
            //            Console.WriteLine(tens_power[len-3] + " ");
            //        }
            //        --len;
            //    }
            //    else
            //    {
            //        if(num[x]-'0' == 1)
            //        {

            //        }
            //    }
            //}

        }

        public static void ExactlyXDivisors()
        {
            Console.WriteLine("Enter the range.");
            int range = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter exact number of divisor.");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int divisorCount = 0;
            for (int i = 1; i <= range; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;

                    }
                }
                if (count == 3)
                {
                    Console.WriteLine(i + " ");
                    divisorCount++;
                }
                if (divisorCount == divisor)
                {
                    return;
                }
            }
        }

        public static void SquareRootOfQuadraticEquation()
        {
            Console.WriteLine("Enter value of A.");
            Double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value of B.");
            Double b = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter value of C.");
            Double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("A value cant be zero.");
            }
            else
            {
                double value = (Math.Pow(b, 2) - 4 * a * c);
                Console.WriteLine("val: " + value);
                double sqrt = Math.Sqrt(value);
                if (value > 0)
                {
                    Console.WriteLine("2 Real roots.");
                    Console.WriteLine((-b + sqrt) / (2 * a));
                    Console.WriteLine((-b - sqrt) / (2 * a));
                }
                else if (value == 0)
                {
                    Console.WriteLine("One real root");
                    Console.WriteLine(-b / (2 * a));
                }
                else
                {
                    Console.WriteLine(-b / (2 * a) + " + i" + sqrt);
                }
            }
        }

        public static void SmallestNumberInArray()
        {
            Console.WriteLine("Enter size of Array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine("Insert " + n + " numbers in array");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine("Minimum number in Array is: {0} ", min);
        }

        public static void SecondSmallestNumberInArray()
        {
            Console.WriteLine("Enter size of Array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine("Insert " + n + " numbers in array");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = numbers[0];
            int SecondSmallest = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                else if (numbers[i] < SecondSmallest && SecondSmallest != min)
                {
                    SecondSmallest = numbers[i];
                }
            }
            Console.WriteLine("second smallest number in Array is: {0} ", SecondSmallest);
        }

        public static int[] AcceptElementsFromArray()
        {
            Console.WriteLine("Enter size of Array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            Console.WriteLine("Insert " + n + " numbers in array");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            return numbers;
        }

        public static void LargestNumberInArray()
        {
            int[] numbers = Utility.AcceptElementsFromArray();
            int largestElement = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largestElement)
                {
                    largestElement = numbers[i];
                }
            }
            Console.WriteLine("Largest Number is array is:{0}", largestElement);
        }

        public static void LargestAndSmallestNumberInArray()
        {
            int[] numbers = Utility.AcceptElementsFromArray();
            int largestElement = numbers[0];
            int smallestElement = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largestElement)
                {
                    largestElement = numbers[i];
                }
                if (numbers[i] < smallestElement)
                {
                    smallestElement = numbers[i];
                }
            }
            Console.WriteLine("Largest Number is array is:{0}", largestElement);
            Console.WriteLine("Smallest Number is array is:{0}", smallestElement);
        }

        public static void SumOfElementsInArray()
        {
            int[] numbers = Utility.AcceptElementsFromArray();
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            Console.WriteLine("Sum of all elements in array is:{0} ", sum);
        }

        public static void ReverseTheArray()
        {
            int[] numbers = Utility.AcceptElementsFromArray();
            int[] reverseNumbers = new int[numbers.Length];
            int j = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                reverseNumbers[j] = numbers[i];
                j++;
            }
            for (int i = 0; i < reverseNumbers.Length; i++)
            {
                Console.WriteLine(reverseNumbers[i]);
            }
        }

        public static void SortArrayInHalfParts()
        {
            int[] numbers = Utility.AcceptElementsFromArray();
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (i < numbers.Length / 2)
                    {
                        if (numbers[j] < numbers[i])
                        {
                            int temp = numbers[j];
                            numbers[j] = numbers[i];
                            numbers[i] = temp;
                        }
                    }
                    else
                    {
                        if (numbers[j] > numbers[i])
                        {
                            int temp = numbers[j];
                            numbers[j] = numbers[i];
                            numbers[i] = temp;
                        }
                    }

                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }

        public static void SortingOfArray()
        {
            int[] numbers = Utility.AcceptElementsFromArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }

        public static void FrequencyOfElementsInArray()
        {
            int[] numbers = Utility.AcceptElementsFromArray();
            int[] freq = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                freq[i] = 0;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            int temp1 = numbers[0];
            int count = 0;
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] == temp1)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine(temp1 + ":" + count);
                    temp1 = numbers[j];
                    j--;
                    count = 0;
                }
                if (j == numbers.Length - 1)
                {
                    Console.WriteLine(temp1 + ":" + count);
                }
            }
            Console.ReadKey();

        }

        public static void LongestPalindromeInArray()
        {
            Console.WriteLine("Enter the size of Array.");
            int n = Convert.ToInt32(Console.ReadLine());
            long[] numbers = new long[n];
            Console.WriteLine("Enter elements in array.");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt64(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[i])
                    {
                        int temp = (int)numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }
            int flag1 = 0;
            for (int j = 0; j < numbers.Length; j++)
            {

                bool response = Utility.PalindromChecker((int)numbers[j]);
                if (response)
                {
                    Console.WriteLine("Longest palindrome is:{0} ", numbers[j]);
                    flag1 = 1;
                    return;
                }

            }
            if (flag1 == 0)
            {
                Console.WriteLine("There is no palindrome present in the array.");
            }

        }


        public static bool PalindromChecker(int number)
        {
            int rem = 0;
            int temp = 0;
            int duplicate = number;
            while (number != 0)
            {
                rem = number % 10;
                temp = (temp * 10) + rem;
                number = number / 10;
            }
            if (duplicate == temp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void DistinctElementInArray()
        {
            int[] numbers = Utility.AcceptElementsFromArray();
            int n = numbers.Length;
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                int j;
                for (j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        break;
                    }
                }
                if (i == j)
                {
                    res++;
                }
            }
            Console.WriteLine("Total number of Distinct elements in array are:{0}", res);
            Console.ReadKey();
            //  Console.WriteLine(res);
        }

        public static void RepeatingElementsInArray()
        {
            int[] numbers = Utility.AcceptElementsFromArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
            Console.ReadKey();
        }

        public static void NonRepeatingElementsInArray()
        {
            int[] numbers = Utility.AcceptElementsFromArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j] && i != j)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.ReadKey();
        }

        public static void RemovingDuplicateElementsInArray()
        {
            int[] numbers = Utility.AcceptElementsFromArray();
            int[] temp = new int[numbers.Length];
            int k = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int j;
                for (j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        break;
                    }
                }
                if (i == j)
                {
                    temp[k] = numbers[i];
                    k++;
                }
            }
            for (int l = 0; l < k; l++)
            {
                Console.Write(temp[l] + " ");
            }
            Console.ReadKey();
        }

        public static void MinimumScalarProductOfTwoArray()
        {
            int[] numbersOne = Utility.AcceptElementsFromArray();
            int[] numbersTwo = Utility.AcceptElementsFromArray();
            if (numbersOne.Length != numbersTwo.Length)
            {
                Console.WriteLine("Array length is not same.");
                return;
            }
            numbersOne = Utility.SortArrayInAscendingOrder(numbersOne);
            numbersTwo = Utility.SortArrayInDescendingOrder(numbersTwo);
            int sum = 0;
            for (int i = 0; i < numbersOne.Length; i++)
            {
                sum = sum + numbersOne[i] * numbersTwo[i];
            }
            Console.WriteLine("Minumum scalar product: {0}", sum);
            Console.ReadKey();
        }

        public static void MaximumScalarProductOfTwoNumber()
        {
            int[] numbersOne = Utility.AcceptElementsFromArray();
            int[] numbersTwo = Utility.AcceptElementsFromArray();
            if (numbersOne.Length != numbersTwo.Length)
            {
                Console.WriteLine("Array length is not same.");
                return;
            }
            numbersOne = Utility.SortArrayInAscendingOrder(numbersOne);
            numbersTwo = Utility.SortArrayInAscendingOrder(numbersTwo);
            int sum = 0;
            for (int i = 0; i < numbersOne.Length; i++)
            {
                sum = sum + numbersOne[i] * numbersTwo[i];
            }
            Console.WriteLine("Maximum scalar product: {0}", sum);
            Console.ReadKey();
        }

        public static int[] SortArrayInAscendingOrder(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[i])
                    {
                        int temp = (int)numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }
            return numbers;
        }

        public static int[] SortArrayInDescendingOrder(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        int temp = (int)numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }
            return numbers;
        }

        public static void CountOfEvenAndOddNumberInArray()
        {
            int[] numbers = Utility.AcceptElementsFromArray();
            int evenCount = 0;
            int oddCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            Console.WriteLine("Even count is " + evenCount + " and odd count is " + oddCount);
        }

        public static void FindAllSymmetricPairs()
        {

        }

        public static int[,] Accept2DArrayElements(int numberOfElements)
        {
            int[,] numbers = new int[numberOfElements, 2];
            Console.WriteLine("Enter the elements in the array.");
            for (int i = 0; i < numberOfElements; i++)
            {
                for (int j = 0; j <= 1; j++)
                {
                    numbers[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return numbers;
            //for (int i = 0; i < numberOfElements; i++)
            //{
            //    for(int j = 0; j <= 1; j++)
            //    {
            //        Console.Write(numbers[i,j]);
            //    }
            //    Console.Write(" ");
            //}
            //Console.WriteLine();
        }

        public static void SymmetricPairInArray()
        {
            Console.WriteLine("Enter number of elements you need.");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] numbers = Utility.Accept2DArrayElements(size);
            int temp = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (numbers[j, 0] < numbers[i, 0])
                    {
                        temp = numbers[j, 0];
                        numbers[j, 0] = numbers[i, 0];
                        numbers[i, 0] = temp;

                        temp = numbers[j, 1];
                        numbers[j, 1] = numbers[i, 1];
                        numbers[i, 1] = temp;
                    }
                }

            }

            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (numbers[i, 1] == numbers[j, 0] && numbers[i, 0] == numbers[j, 1])
                    {
                        Console.Write("(" + numbers[j, 1] + "," + numbers[i, 1] + ")" + " ");
                    }
                }
            }
            Console.ReadKey();

        }

        /// <summary>
        /// Pending program need to complete it tomorrow
        /// </summary>
        public static void MaximumProductOfSubArray()
        {
            int[] numbers = Utility.AcceptElementsFromArray();
            int maxProduct = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if ((numbers[i] * numbers[j] * maxProduct) < maxProduct)
                    {
                        break;
                    }
                    else
                    {
                        maxProduct = maxProduct * (numbers[i] * numbers[j]);
                    }
                }
            }
            Console.WriteLine("Max product:{0}", maxProduct);
        }

        public static void DisjointArray()
        {
            int[] arrayOne = Utility.AcceptElementsFromArray();
            int[] arrayTwo = Utility.AcceptElementsFromArray();
            bool flag = false;
            for (int i = 0; i < arrayOne.Length; i++)
            {
                for (int j = 0; j < arrayTwo.Length; j++)
                {
                    if (arrayOne[i] == arrayTwo[j])
                    {
                        flag = true;
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("Array is not disjoint.");
            }
            else
            {
                Console.WriteLine("Array is disjoint.");
            }
        }

        public static void DetermineTheArrayIsSubsetOfAnotherArray()
        {
            int[] arraysOne = Utility.AcceptElementsFromArray();
            int[] arrayTwo = Utility.AcceptElementsFromArray();
            if (arrayTwo.Length > arraysOne.Length)
            {
                Console.WriteLine("Invalid Array to determine subset of array.");
                DetermineTheArrayIsSubsetOfAnotherArray();
            }
            else
            {
                bool flag = false;
                for (int i = 0; i < arraysOne.Length; i++)
                {
                    int count = 0;
                    for (int j = 0; j < arrayTwo.Length; j++)
                    {
                        if (arraysOne[i] != arrayTwo[j])
                        {
                            break;
                        }
                        else
                        {
                            count++;
                            if (count == arrayTwo.Length)
                            {
                                Console.WriteLine("Array 2 is subset of array 1.");
                                flag = true;
                            }
                            i++;
                        }


                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Array 2 is not subset of array 1.");
                }
                Console.ReadKey();
            }

        }

        public static void CheckIfAllTheNumbersOfArraysCanBeMadeEqual()
        {
            int[] numbers = Utility.AcceptElementsFromArray();
            bool flag = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                while (numbers[i] % 2 == 0)
                {
                    numbers[i] = numbers[i] / 2;
                }
                while (numbers[i] % 3 == 0)
                {
                    numbers[i] = numbers[i] / 3;
                }
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[0])
                {
                    Console.WriteLine("Cannot be Equal.");
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("can be equal.");
            }
            Console.ReadKey();

        }

        public static void FindingMinimumSumOfAbsoluteDifferenceOfGivenArray()
        {
            int[] numbers = Utility.AcceptElementsFromArray();
            Array.Sort(numbers);
            int n = numbers.Length;
            int x = numbers[(int)n / 2];
            int sum = 0;
            Console.WriteLine("x." + x);
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + Math.Abs(numbers[i] - x);
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        public static void SortElementsByTheirFrequency()
        {

        }

        public static void SortAnArrayAccordingToOrderDefinedByOtherArray()
        {
            int[] numbers = Utility.AcceptElementsFromArray();
            int[] numbers1 = Utility.AcceptElementsFromArray();
            for (int i = 0; i < numbers1.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers1[i] == numbers[j])
                    {
                        Console.Write(numbers[j] + " ");
                    }
                }
            }

            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                count = 0;
                for (int j = 0; j < numbers1.Length; j++)
                {
                    if (numbers[i] == numbers1[j])
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void ReplaceEachElementByItsRankInTheGivenArray()
        {
            int[] numbers = Utility.AcceptElementsFromArray();
            int[] numbers1 = new int[numbers.Length];
            int[] numbers2 = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers1[i] = numbers[i];
            }
            int rank = 1;
            Array.Sort(numbers1);
            for (int i = 0; i < numbers1.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers1[i] == numbers[j])
                    {
                        numbers2[j] = rank;
                        rank++;
                    }
                }
            }
            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.Write(numbers2[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void EquilibriumIndex()
        {
            int[] numbers = Utility.AcceptElementsFromArray();
            int median = numbers.Length / 2;
            int leftSum = 0;
            int rightSum = 0;
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < median)
                {
                    leftSum = leftSum + numbers[i];
                    count++;
                }
                if (i > median)
                {
                    rightSum = rightSum + numbers[i];
                }
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("index:{0} ", count);
            }
            Console.WriteLine("left sum:{0} ", leftSum);
            Console.WriteLine("right sum:{0} ", rightSum);
        }

        public static void RotatingArrayTowardsLeft()
        {
            int[] numbers = Utility.AcceptElementsFromArray();
            Console.WriteLine("Enter the key by which need to rotate.");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int j, first = 0;
                first = numbers[0];
                for (j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }
                numbers[j] = first;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + " ");

            }
        }

        public static void RotatingArrayTowardsRight()
        {
            int[] numbers = Utility.AcceptElementsFromArray();
            Console.WriteLine("Enter the key by which need to rotate.");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int j, last = 0;
                last = numbers[numbers.Length - 1];
                for (j = numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }
                numbers[j] = last;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + " ");

            }
        }

        public static void FindStringLength()
        {
            Console.WriteLine("Enter the string.");
            string s = Console.ReadLine();
            char[] c = s.ToCharArray();
            int length = 0;
            for (int i = 0; i < c.Length; i++)
            {
                length++;
            }
            Console.WriteLine("lenght of string:{0}", length);
        }

        public static void ToggleEachCharacterInString()
        {
            Console.WriteLine("Enter the string.");
            string s = Console.ReadLine();
            string s1 = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                {
                    s1 = s1 + Char.ToLower(s[i]);
                }
                else
                {
                    s1 = s1 + Char.ToUpper(s[i]);
                }
            }
            Console.WriteLine(s1);
        }

        public static void CountOfVowels()
        {
            Console.WriteLine("Enter the string.");
            string s = Console.ReadLine();
            char[] c = s.ToCharArray();
            int vowel = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 'a' || c[i] == 'e' || c[i] == 'i' || c[i] == 'o' || c[i] == 'u')
                {
                    vowel++;
                }
            }
            Console.WriteLine("Total vowels are:{0}", vowel);
        }

        public static void RemoveVowelsFromString()
        {
            Console.WriteLine("Enter the string.");
            string s = Console.ReadLine();
            s = s.Replace("a", "").Replace("e", "").Replace("i", "").Replace("0", "").Replace("u", "");
            Console.WriteLine("string after replacing vowels:{0}", s);
            Console.ReadKey();
        }

        public static void CheckStringPalindromeOrNote()
        {
            Console.WriteLine("Enter the string.");
            string s = Console.ReadLine();
            string rev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev = rev + s[i];
            }
            if (rev == s)
            {
                Console.WriteLine("String is palindrome.");
            }
            else
            {
                Console.WriteLine("String is not palindrome.");
            }
            Console.ReadKey();
        }

        public static void ReplaceSubStringInString()
        {
            Console.WriteLine("Enter the string.");
            string s = Console.ReadLine();
            Console.WriteLine("Enter string to replace.");
            string oldString = Console.ReadLine();
            Console.WriteLine("Enter new string to be replaced");
            string newString = Console.ReadLine();
            s = s.Replace(oldString, newString);
            Console.WriteLine("String after replace:{0}", s);
            Console.ReadKey();
        }

        public static void ReverseTheString()
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            string rev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev = rev + s[i];
            }
            Console.WriteLine("Reverse string: {0}", rev);
            Console.ReadKey();
        }

        public static void RemoveCharExceptAlphabet()
        {
            Console.WriteLine("Enter the string.");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {

                if (!Char.IsLetter(s[i]))
                {
                    s = s.Replace(s[i].ToString(), "");
                }
            }
            Console.WriteLine("string after removing numbers:{0}", s);
            Console.ReadKey();
        }

        public static void RemoveSpaceFromString()
        {
            Console.WriteLine("Enter the string.");
            string s = Console.ReadLine();
            string s2 = "";
            char[] s1 = s.ToCharArray();
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != ' ')
                {
                    s2 = s2 + s1[i];
                }
            }

            //s = new string(s1);
            Console.WriteLine("New string after removing spaces:{0}", s2);
            Console.ReadKey();
        }

        public static void ReplaceBracketsFromExpression()
        {
            Console.WriteLine("Enter the string.");
            string s = Console.ReadLine();
            s = s.Replace("(", "").Replace(")", "").Replace("{", "").Replace("}", "").Replace("[", "").Replace("]", "");
            Console.WriteLine("The string after replacing brackets is {0}", s);
            Console.ReadKey();
        }

        public static void SumOfNumbersOfString()
        {
            Console.WriteLine("Enter the string.");
            string s = Console.ReadLine();
            char[] s1 = s.ToCharArray();
            int sum = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (Char.IsDigit(s1[i]))
                {
                    Console.WriteLine(s1[i] + " ");
                    sum = sum + Convert.ToInt32(Char.GetNumericValue(s1[i]));
                }
            }
            Console.WriteLine("sum of digits in string is:{0}", sum);
            Console.ReadKey();
        }

        public static void CapitalizeFirstAndLastLetterOfEachWordOfString()
        {
            Console.WriteLine("Enter the string.");
            string s = Console.ReadLine();
            string[] s1 = s.Split(" ");
            string s3 = "";
            for (int i = 0; i < s1.Length; i++)
            {
                int j = 0;
                string s2 = "";
                for (j = 0; j < s1[i].Length; j++)
                {
                    if (j == 0 || j == s1[i].Length - 2)
                    {
                        s1[j] = s1[j].ToUpper();
                    }

                    s2 = s2 + s1[j];
                }
                s3 = s3 + s2;
            }
            Console.WriteLine(s3);
        }

        public static void FrequencyOfCharacterInString()
        {
            Console.WriteLine("Enter the string to check the frequency.");
            string s1 = Console.ReadLine();
            int count = 1;
            for (int i = 0; i < s1.Length; i++)
            {
                count = 1;
                int flag = 0;
                for (int j = i + 1; j < s1.Length; j++)
                {
                    if (s1[i] == s1[j])
                    {
                        count++;
                    }
                }
                for (int k = 0; k < i; k++)
                {
                    if (s1[i] == s1[k])
                    {
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine(s1[i] + " " + count);
                }
            }
            Console.ReadKey();
        }

        public static void NonRepeatingCharacterInString()
        {
            Console.WriteLine("Enter the string to check non repeating frequency.");
            string s1 = Console.ReadLine();
            int count = 1;
            for (int i = 0; i < s1.Length; i++)
            {
                count = 1;
                int flag = 0;
                for (int j = i + 1; j < s1.Length; j++)
                {
                    if (s1[i] == s1[j])
                    {
                        count++;
                    }
                }
                for (int k = 0; k < i; k++)
                {
                    if (s1[i] == s1[k])
                    {
                        flag = 1;
                    }
                }
                if (flag == 0 && count == 1)
                {
                    Console.WriteLine(s1[i] + " " + count);
                }
            }
            Console.ReadKey();
        }

        public static void StringsAreAnagramOrNot()
        {
            Console.WriteLine("Enter the string 1.");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter the string 2.");
            string s2 = Console.ReadLine();
            if (s1.Length == s1.Length)
            {
                char[] arr1 = s1.ToCharArray();
                char[] arr2 = s2.ToCharArray();
                Array.Sort(arr1);
                Array.Sort(arr2);
                if (arr1.SequenceEqual(arr2))
                {
                    Console.WriteLine("Strings are anagram.");
                }
                else
                {
                    Console.WriteLine("Strings are not a anagram.");
                }
            }
            else
            {
                Console.WriteLine("Strings are not anagram.");
            }
            Console.ReadKey();
        }

        public static void ReplaceOldStringInAString()
        {
            Console.WriteLine("Enter the old string.");
            string oldString = Console.ReadLine();

            Console.WriteLine("Enter the string which need to replaced");
            string replaceString = Console.ReadLine();

            Console.WriteLine("Enter new string which need to replace");
            string newString = Console.ReadLine();

            string replacedString = oldString.Replace(replaceString, newString);
            Console.WriteLine(replacedString);
            Console.ReadKey();
        }

        public static void SetOperation()
        {
            int ch = 0;
            do
            {
                Console.WriteLine("1. Exit");
                Console.WriteLine("2. Union");
                Console.WriteLine("3. Intersection");
                Console.WriteLine("4. Difference");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 2:
                        Utility.Union();
                        break;
                    case 3:
                        Utility.Intersection();
                        break;
                    case 4:
                        Utility.Difference();
                        break;
                }
            }
            while (ch != 1);
        }

        public static void Union()
        {
            int[] arrayOne = Utility.AcceptElementsFromArray();
            int[] arrayTwo = Utility.AcceptElementsFromArray();
            int[] resultArray = new int[arrayOne.Length + arrayTwo.Length];
            int l = 0;
            for (int i = 0; i < arrayOne.Length; i++)
            {
                int flag = 0;
                for (int j = 0; j < resultArray.Length; j++)
                {
                    if (arrayOne[i] == resultArray[j])
                    {
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    resultArray[l] = arrayOne[i];
                    l++;
                }
            }

            for (int i = 0; i < arrayTwo.Length; i++)
            {
                int flag = 0;
                for (int j = 0; j < resultArray.Length; j++)
                {
                    if (arrayTwo[i] == resultArray[j])
                    {
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    resultArray[l] = arrayTwo[i];
                    l++;
                }
            }

            for (int i = 0; i < l; i++)
            {
                Console.Write(resultArray[i] + " ");
            }
            Console.ReadKey();
        }

        public static void Intersection()
        {
            int[] arrayOne = Utility.AcceptElementsFromArray();
            int[] arrayTwo = Utility.AcceptElementsFromArray();
            int[] resultArray = new int[arrayOne.Length + arrayTwo.Length];
            int l = 0;
            for (int i = 0; i < arrayOne.Length; i++)
            {
                for (int j = 0; j < arrayTwo.Length; j++)
                {
                    if (arrayOne[i] == arrayTwo[j])
                    {
                        resultArray[l] = arrayTwo[j];
                        l++;
                    }
                }
            }

            for (int i = 0; i < l; i++)
            {
                Console.Write(resultArray[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Difference()
        {
            int[] arrayOne = Utility.AcceptElementsFromArray();
            int[] arrayTwo = Utility.AcceptElementsFromArray();
            int[] resultArray = new int[arrayOne.Length + arrayTwo.Length];
            int l = 0;
            for (int i = 0; i < arrayOne.Length; i++)
            {
                int flag = 0;
                for (int j = 0; j < arrayTwo.Length; j++)
                {
                    if (arrayOne[i] == arrayTwo[j])
                    {
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    resultArray[l] = arrayOne[i];
                    l++;
                }
            }

            for (int i = 0; i < l; i++)
            {
                Console.Write(resultArray[i] + " ");
            }
            Console.WriteLine();
        }


        public static MatrixValues AcceptElementFor2DMatrix()
        {
            MatrixValues matrixValues = new MatrixValues();
            Console.WriteLine("Enter the rows for matrix.");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the colums for matrix.");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] arr2d = new int[rows, column];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    arr2d[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            matrixValues.row = rows;
            matrixValues.column = column;
            matrixValues.ArrayValues = arr2d;
            return matrixValues;
        }

        public static void AdditionOf2DArray()
        {
            MatrixValues firstArray = Utility.AcceptElementFor2DMatrix();
            MatrixValues secondArray = Utility.AcceptElementFor2DMatrix();
            int[,] resultArray = new int[firstArray.row, firstArray.column];
            for (int i = 0; i < firstArray.row; i++)
            {
                for (int j = 0; j < firstArray.column; j++)
                {
                    resultArray[i, j] = firstArray.ArrayValues[i, j] + secondArray.ArrayValues[i, j];
                }
            }

            for (int i = 0; i < firstArray.row; i++)
            {
                for (int j = 0; j < firstArray.column; j++)
                {
                    Console.Write(resultArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public struct MatrixValues
        {
            public int row;
            public int column;
            public int[,] ArrayValues;
        }

        public static void BubbleSort()
        {
            int[] arrayElements = Utility.AcceptElementsFromArray();
            for (int i = 0; i < arrayElements.Length; i++)
            {
                for (int j = 0; j < arrayElements.Length - 1; j++)
                {
                    if (arrayElements[j] > arrayElements[j + 1])
                    {
                        int temp = arrayElements[j + 1];
                        arrayElements[j + 1] = arrayElements[j];
                        arrayElements[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arrayElements.Length; i++)
            {
                Console.Write(arrayElements[i] + " ");
            }
            Console.ReadKey();
        }

        public static void SelectionSort()
        {
            int[] arrayElements = Utility.AcceptElementsFromArray();
            int val = 0;
            int val1 = 0;
            // 2 4 5 1 2 6
            for (int i = 0; i < arrayElements.Length; i++)
            {
                int min = arrayElements[val];
                int minIndex = 0;
                for (int j = val; j < arrayElements.Length; j++)
                {
                    if (arrayElements[j] < min)
                    {
                        minIndex = j;
                        min = arrayElements[j];
                    }
                }
                int temp = arrayElements[i];
                val++;
                arrayElements[i] = arrayElements[minIndex];
                arrayElements[minIndex] = arrayElements[i];
            }

            for (int i = 0; i < arrayElements.Length; i++)
            {
                Console.Write(arrayElements[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
