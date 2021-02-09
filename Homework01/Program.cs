using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Guessing Game

            //Random RandomNumber = new Random();
            //int SecretNumber = RandomNumber.Next(1,99);
            //int attempts = 0;
            //List<int> UserNumbersList = new List<int>();
            //Console.WriteLine("Please Input the number");
            //Start:
            //int UserNumber = Convert.ToInt32(Console.ReadLine());
            //int Sum = UserNumber - SecretNumber;
            //foreach (var item in UserNumbersList)
            //{
            //    if (item == UserNumber)
            //    {
            //        Console.WriteLine("You have already wrote that number. Please try again");
            //        goto Start;
            //    }
            //}
            //UserNumbersList.Add(UserNumber);
            //for (int i = 0; i > -1; i++)
            //{
            //    attempts++;
            //    if (UserNumber == SecretNumber)
            //    {
            //        Console.WriteLine("Congratulation! You guessed the number");
            //        break;
            //    }
            //    else if (Sum < -20)
            //    {
            //        Console.WriteLine("Too small from number. Please Try again");
            //        goto Start;
            //    }
            //    else if (Sum >= 10 && Sum <= 20)
            //    {
            //        Console.WriteLine("Close but larger. Please Try again");
            //        goto Start;
            //    }
            //    else if (Sum >= -20 && Sum <= -10)
            //    {
            //        Console.WriteLine("Close but smaller. Please Try again");
            //        goto Start;
            //    }
            //    else if (Sum > -10 && Sum < 0)
            //    {
            //        Console.WriteLine("Too close to number but smaller. Please Try again");
            //        goto Start;
            //    }
            //    else if (Sum < 10 && Sum > 0)
            //    {
            //        Console.WriteLine("Too close to number but larger. Please Try again");
            //        goto Start;
            //    }
            //    else if (Sum > 20)
            //    {
            //        Console.WriteLine("Too large from number. Please Try again");
            //        goto Start;
            //    }
            //}
            //Console.WriteLine($"Your number of attempts: {attempts}");
            //Console.ReadLine();






            // #1


            //    Console.Write("Please enter any integer: ");
            //    int Number = Convert.ToInt32(Console.ReadLine());
            //Start:
            //    Console.Write("For computing sum enter 1, for computing multiplication enter 2: ");
            //    string choice = Console.ReadLine();
            //    int ConvertedChoice;
            //    bool action = Int32.TryParse(choice, out ConvertedChoice);
            //    int Plus = 0;
            //    int Multiplication = 1;
            //    if (action)
            //    {
            //        for (int i = 1; i <= Number; i++)
            //        {
            //            if (ConvertedChoice == 1)
            //            {
            //                Plus += i;
            //            }
            //            else if (ConvertedChoice == 2)
            //            {
            //                Multiplication *= i;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Please enter the right action: ");
            //                goto Start;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Input string was not in a correct format, try again.");
            //        goto Start;
            //    }

            //    if (ConvertedChoice == 1)
            //    {
            //        Console.Write("The result is: " + Plus);
            //    }
            //    else if (ConvertedChoice == 2)
            //    {
            //        Console.Write("The result is: " + Multiplication);
            //    }
            //     Console.ReadLine();





            // #2 Leap years

            //DateTime date = new DateTime(2021, 1, 1);
            //LeapYears(date);




            // #3 RectangularBox

            //List<string> sentence = new List<string>();
            //sentence.Add("Hello");
            //sentence.Add("World");
            //sentence.Add("in");
            //sentence.Add("the");
            //sentence.Add("box");
            //RectangularBox(sentence);   



            // # 4

            //string[] a = { "The", "quick", "brown", "fox", "jumped", "over", "the", "lazy", "dog" };
            //MoveTheFirstLetter(a);
        }

        //static void MoveTheFirstLetter(string[] a)
        //{
        //    var str = "";
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        str = a[i];
        //        str = string.Join("", str.Skip(1)) + str[0];
        //        Console.Write($" {str}ey");
        //    }
        //}

        //static void RectangularBox(List<string> sentence)
        //{
        //    string MultiplySymbol = "*********";
        //    Console.WriteLine(MultiplySymbol);
        //    for (int i = 0; i < sentence.Count; i++)
        //    {
        //        string symbols = sentence[i];
        //        int sum = MultiplySymbol.Length - symbols.Length;
        //        Console.WriteLine("* " + sentence[i] + String.Concat(Enumerable.Repeat(" ", sum - 3)) + "*");
        //    }
        //    Console.WriteLine(MultiplySymbol);
        //}

        //static void LeapYears(DateTime date)
        //{
        //    int leapyears = 0;
        //    for (int i = date.Year; i < 2041; i++)
        //    {
        //        if (date.Year % 4 == 0)
        //        {
        //            leapyears++;
        //        }
        //        date = date.AddYears(1);  // es masy google_ic em nayel vorovhetev uxaki grum ei 'date.AddYears(1)' cher ashxatum parzvuma petqa grei ' date = ...'
        //    }
        //    Console.WriteLine($"There are {leapyears} leap years");
        //}

    }
}