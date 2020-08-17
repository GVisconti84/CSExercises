using System;

namespace CSExercises
{
    class Chapeter3ex
    {
        static void LocalMain(string[] args)
        {
            Console.Write(" ###### ESERCIZIO 3.15 ######\n");

            int a;
            int b;

            Console.Write("Insert first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);

            if (b == 0)
            {
                Console.WriteLine("{0} / {1} = Impossibile", a, b);
            }
            else Console.WriteLine("{0} / {1} = {2}", a, b, a / b);

            Console.Write(" ###### FINE ESERCIZIO  ######\n");
            Console.Write("\n");


            Console.Write(" ###### ESERCIZIO 3.16 ######\n");
            int c;
            int d;
            Console.Write("Insert first number: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert second number: ");
            d = Convert.ToInt32(Console.ReadLine());

            if (c > d)
            {
                Console.Write("{0} is larger than {1}\n", c, d);
            }
            else if (c == d)
            {
                Console.Write("{0} and {1} are equals\n", c, d);
            }
            else if (d > c)
            {
                Console.Write("{0} is larger than {1}\n", d, c);
            }

            Console.Write(" ###### FINE ESERCIZIO  ######\n");
            Console.Write("\n");


            Console.Write(" ###### ESERCIZIO 3.17 ######\n");
            int e;
            int f;
            int h;
            int max = 0;
            int min = 0;
            int prod;
            int avg;
            int sum;

            Console.Write("Insert first number: ");
            e = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert second number: ");
            f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert third number: ");
            h = Convert.ToInt32(Console.ReadLine());

            prod = e * f * h;
            sum = e + f + h;
            avg = (e + f + h) / 3;

            if (e > f && e > h)
            {
                max = e;
                if (f > h)
                {
                    min = h;
                }
                else min = f;
            }

            else if (e > f && e < h)
            {
                max = h;
                min = f;
            }

            else if (e < f && e < h)
            {
                min = e;
                if (h < f)
                {
                    max = f;
                }
                else max = h;
            }

            Console.WriteLine("The product of {0} {1} {2} is: {3} ", e, f, h, prod);
            Console.WriteLine("The product of {0} {1} {2} is: {3} ", e, f, h, sum);
            Console.WriteLine("The average of {0} {1} {2} is: {3} ", e, f, h, avg);
            Console.WriteLine("The max between {0} {1} {2} is: {3} ", e, f, h, max);
            Console.WriteLine("The min between {0} {1} {2} is: {3} ", e, f, h, min);

            Console.Write(" ###### FINE ESERCIZIO  ######\n");
            Console.WriteLine("");




            Console.WriteLine("*********       ***         *           *");
            Console.WriteLine("*       *    *       *     ***         * *");
            Console.WriteLine("*       *   *         *   *****       *   *");
            Console.WriteLine("*       *   *         *     *        *     *");
            Console.WriteLine("*       *   *         *     *       *       *");
            Console.WriteLine("*       *   *         *     *        *     *");
            Console.WriteLine("*       *   *         *     *         *   *");
            Console.WriteLine("*       *    *       *      *          * *");
            Console.WriteLine("*********       ***         *           *");

            Console.WriteLine(" ###### FINE ESERCIZIO ######");
            Console.WriteLine("");

            Console.WriteLine(" ###### ESERCIZIO 3.24 ######");
            int i;


            Console.WriteLine("Insert number number: ");
            i = Convert.ToInt32(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine("{0} is even", i);
            }
            else Console.WriteLine("{0} is odd", i);
            Console.WriteLine(" ###### FINE ESERCIZIO ######");
            Console.WriteLine("");


            Console.WriteLine(" ###### ESERCIZIO 3.25 ######");

            int m;
            int n;
            Console.WriteLine("Insert first number: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert second number: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % m == 0)
            {
                Console.WriteLine("{0} is a multiple of {1}", n, m);
            }
            else Console.WriteLine("{0} is not a multiple of {1}", n, m);
            Console.WriteLine(" ###### FINE ESERCIZIO ######");
            Console.WriteLine("");


            Console.WriteLine(" ###### ESERCIZIO 3.26 ######");

            Console.WriteLine("Insert radius: \n");

            int radius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area: {0}", (radius * radius) * Math.PI);
            Console.WriteLine("Circumference: {0}", 2 * Math.PI * radius);
            Console.WriteLine("Diameter: {0}", 2 * radius);
            Console.WriteLine(" ###### FINE ESERCIZIO ######\n");

            Console.WriteLine(" ###### ESERCIZIO 3.27 ######\n");
            Console.WriteLine("The character list \n{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13}\nhas the following value:\n{14} {15} {16} {17} {18} {19} {20} {21} {22} {23} {24} {25} \n",
                'A', 'B', 'C', 'a', 'b', 'c', '0', '1', '2', '$', '*', '+', '/', ' ', ((int)'A'), ((int)'B'), ((int)'C'), ((int)'a'), ((int)'b'), ((int)'c'), ((int)'0'), ((int)'1'),
                 ((int)'2'), ((int)'$'), ((int)'*'), ((int)'+'), ((int)'/'), ((int)' '));

            Console.WriteLine(" ###### FINE ESERCIZIO ######\n");

            Console.WriteLine(" ###### ESERCIZIO 3.28 ######\n");

            //TODO

            Console.WriteLine(" ###### FINE ESERCIZIO ######\n");


            Console.WriteLine(" ###### ESERCIZIO 3.29 ######\n");
            int x;
            x = 0;
            Console.WriteLine("number   square  cube");
            Console.WriteLine("{0}      {1}     {2}", x, x * x, x * x * x);
            x++;
            Console.WriteLine("{0}      {1}     {2}", x, x * x, x * x * x);
            x++;
            Console.WriteLine("{0}      {1}     {2}", x, x * x, x * x * x);
            x++;
            Console.WriteLine("{0}      {1}     {2}", x, x * x, x * x * x);
            x++;
            Console.WriteLine("{0}      {1}     {2}", x, x * x, x * x * x);
            x++;
            Console.WriteLine("{0}      {1}     {2}", x, x * x, x * x * x);
            x++;
            Console.WriteLine("{0}      {1}     {2}", x, x * x, x * x * x);
            x++;
            Console.WriteLine("{0}      {1}     {2}", x, x * x, x * x * x);
            x++;
            Console.WriteLine("{0}      {1}     {2}", x, x * x, x * x * x);
            x++;
            Console.WriteLine("{0}      {1}     {2}", x, x * x, x * x * x);
            x++;
            Console.WriteLine("{0}      {1}     {2}", x, x * x, x * x * x);
            Console.WriteLine(" ###### FINE ESERCIZIO ######\n");


            Console.WriteLine(" ###### ESERCIZIO 3.30 ######\n");
            int negative = 0;
            int zero = 0;
            int positive = 0;
            Console.WriteLine("Insert first number");
            int one = Convert.ToInt32(Console.ReadLine());
            if (one > 0)
            {
                positive++;
            }
            else if (one < 0)
            {
                negative++;
            }
            else
            {
                zero++;
            }
            Console.WriteLine("Insert second number");
            int two = Convert.ToInt32(Console.ReadLine());
            if (two > 0)
            {
                positive++;
            }
            else if (two < 0)
            {
                negative++;
            }
            else
            {
                zero++;
            }
            Console.WriteLine("Insert third number");
            int three = Convert.ToInt32(Console.ReadLine());
            if (three > 0)
            {
                positive++;
            }
            else if (three < 0)
            {
                negative++;
            }
            else
            {
                zero++;
            }
            Console.WriteLine("Insert fourth number");
            int four = Convert.ToInt32(Console.ReadLine());
            if (four > 0)
            {
                positive++;
            }
            else if (four < 0)
            {
                negative++;
            }
            else
            {
                zero++;
            }
            Console.WriteLine("Insert fifth number");
            int five = Convert.ToInt32(Console.ReadLine());
            if (five > 0)
            {
                positive++;
            }
            else if (five < 0)
            {
                negative++;
            }
            else
            {
                zero++;
            }

            Console.WriteLine("Positive: {0}\nNegative: {1}\nZero: {2}", positive, negative, zero);

        }
    }
}
