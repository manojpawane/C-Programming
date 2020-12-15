﻿using ProgramInCSharp;
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
            Console.WriteLine("17. Factorial of Number.");
            Console.WriteLine("18. Factors of number.");
            Console.WriteLine("19. Strong Number or not.");
            Console.WriteLine("20. Power of Number.");
            Console.WriteLine("21. Perfect Number..");
            Console.WriteLine("22. Automorphic Number..");
            Console.WriteLine("23. Harshad Number..");
            Console.WriteLine("24. Abundant Number..");
            Console.WriteLine("25. Friendly pair..");
            Console.WriteLine("26. Gcd Or Hcf");
            Console.WriteLine("27. Gcd Or Hcf using euclidean");
            Console.WriteLine("28. LCM of 2 Numbers..");
            Console.WriteLine("29. Binary to Decimal..");
            Console.WriteLine("30. Binary to Octal..");
            Console.WriteLine("31. Decimal To Binary..");
            Console.WriteLine("32.  Decimal To Octal..");
            Console.WriteLine("33. Octal To Binary..");
            Console.WriteLine("34. Octal to Decimal..");
            Console.WriteLine("35. Quadrant In Coordinates..");
            Console.WriteLine("36. Permutation of Classroom..");
            Console.WriteLine("37. Handshake Program..");
            Console.WriteLine("38. Addition of Two fractions..");
            Console.WriteLine("39. Replace Zero with One's..");
            Console.WriteLine("40. Expressed Sum of Two Prime Number..");
            Console.WriteLine("41. Check Vowel");
            Console.WriteLine("42. CharacterIsAlphabetOrNot");
            Console.WriteLine("43. Area of circle");
            Console.WriteLine("44. ASCII value of character..");
            Console.WriteLine("45. Prime number in a range..");
            Console.WriteLine("46. Print Plus and minus.");
            Console.WriteLine("47. Replace string with underscore");
            Console.WriteLine("48. Find digits in integer.");
            Console.WriteLine("49. Number of days in month of year.");
            Console.WriteLine("50. Convert Number to words.");
            Console.WriteLine("51. ExactlyXDivisors.");
            Console.WriteLine("52. Square Root Of QuadraticEquation");
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
                case 17:Utility.FactorialOfNumber(10);
                    break;
                case 18: Utility.FactorsOfNumber();
                    break;
                case 19: Utility.StrongNumber();
                    break;
                case 20:Utility.PoweroFNumber();
                    break;
                case 21:Utility.PerfectNumber();
                    break;
                case 22: Utility.AuthomorphicNumber();
                    break;
                case 23:Utility.HarshadNumber();
                    break;
                case 24:Utility.AbdundantNumber();
                    break;
                case 25: Utility.FriendlyPair();
                    break;
                case 26:Utility.GcdOrHcf();
                    break;
                case 27: Utility.EuclideanAlgorithm(5, 10);
                    break;
                case 28:Utility.LcmFor(4, 2);
                    break;
                case 29: Utility.BinaryToDecimal();
                    break;
                case 30:Utility.BinaryToOctal();
                    break;
                case 31:Utility.DecimalToBinary();
                    break;
                case 32: Utility.DecimalToOctal();
                    break;
                case 33:Utility.OctalToBinary();
                    break;
                case 34:Utility.OctalToDecimail();
                    break;
                case 35:Utility.QuadrantInCoordinates();
                    break;
                case 36:Utility.PermutationInClassroom();
                    break;
                case 37: Utility.HandShakeProgram();
                    break;
                case 38:Utility.AdditionOfTwoFraction();
                    break;
                case 39:Utility.Replace0With1v2();
                    break;
                case 40:Utility.ExpressedAsSumOfTwoPrimeNumber();
                    break;
                case 41:Utility.CheckVowel();
                    break;
                case 42:Utility.CharacterIsAlphabetOrNot();
                    break;
                case 43:Utility.AreaOfCircle();
                    break;
                case 44:Utility.ASCIIValueOfCharacter();
                    break;
                case 45:Utility.PrimeNumberBetweenMinAndMax();
                    break;
                case 46:Utility.PrintPlusAndMinus();
                    break;
                case 47:Utility.ReplaceStringWithUnderScore();
                    break;
                case 48:Utility.NumberOfDigitsInAnInteger();
                    break;
                case 49:Utility.ProgramOfNumberOfDays();
                    break;
                case 50:Utility.ConvertNumberToWords();
                    break;
                case 51:Utility.ExactlyXDivisors();
                    break;
                case 52:Utility.SquareRootOfQuadraticEquation();
                    break;
            }
        }
        while (ch != 1 );
    }
}