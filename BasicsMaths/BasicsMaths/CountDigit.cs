using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BasicsMaths
{
    internal class CountDigit
    {

        //Given a number n. Count the number of digits in n which evenly divide n.
        //Return an integer, total number of digits of n which divides n evenly.
        // Note :- Evenly divides means whether n is divisible by a digit i.e.
        // leaves a remainder 0 when divided.
        public int GetDigitCount(int number)
        {
            int count = 0;
            int temp = number;

            while (temp > 0)
            {
                int lastDigit = temp % 10;
                if (number % lastDigit == 0)
                    count++;
                temp = temp / 10;
            }

            return count;

        }
    }
}

