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
    }
}
