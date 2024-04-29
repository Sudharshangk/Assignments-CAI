//Create a function that takes a number and returns its multiplicative persistence, 
//which is the number of times you must multiply the digits in number until you reach a single digit.
//bugger(39) ➞ 3
// Because 3 * 9 = 27, 2 * 7 = 14, 1 * 4 = 4 and 4 has only one digit.
//bugger(999) ➞ 4
// Because 9 * 9 * 9 = 729, 7 * 2 * 9 = 126, 1 * 2 * 6 = 12, and finally 1 * 2 = 2.
//bugger(4) ➞ 0
// Because 4 is already a one-digit number.


using System;

class MultiplicativePersistent

{

    static void Main(string[] args)

    {

        Console.WriteLine("Multiplicative Persistence of 39: " + Bugger(39));

        Console.WriteLine("Multiplicative Persistence of 999: " + Bugger(999));

        Console.WriteLine("Multiplicative Persistence of 4: " + Bugger(4));

    }

    static int Bugger(int number)

    {

        int persistence = 0;

        while (number >= 10)

        {

            int product = 1;

            while (number > 0)

            {

                product *= number % 10;

                number /= 10;

            }

            number = product;

            persistence++;

        }

        return persistence;

    }

}