using System;

class HelloWorld
{
    static void Main()
    {
        long number_card = Convert.ToInt64(Console.ReadLine()), first_digit = 0, x2 = 0, asum = 0, x2p = 0, sum = 0, d2, m;
        bool val;
        while (number_card > 0)
        {
            x2 = first_digit;
            first_digit = number_card % 10;
            if (asum % 2 == 0)
            {
                sum += first_digit;
            }
            else
            {
                m = 2 * first_digit;
                x2p += (m / 10) + (m % 10);
            }
            number_card /= 10;
            asum++;
        }
        val = (sum + x2p) % 10 == 0;
        d2 = (first_digit * 10) + x2;

        if (first_digit == 4 && asum >= 13 && asum <= 16 && val)
        {
            Console.WriteLine("VISA");
        }
        else if (d2 >= 51 && d2 <= 55 && asum == 16 && val)
        {
            Console.WriteLine("MASTERCARD");
        }
        else
        {
            Console.WriteLine("INVALID");
        }
    }
} 