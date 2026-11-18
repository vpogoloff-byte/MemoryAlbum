using System;
using System.IO;

class Program
{
    static void Main()
    {
        string input;
        int a, b, c;

        input = Console.ReadLine();

        string[] line = input.Split(' ');
        a = int.Parse(line[0]);
        b = int.Parse(line[1]);
        c = int.Parse(line[2]);

        if ((a > b && a <= c) || (a > c && a < b))
        {
            Console.WriteLine(a);
        }
        if ((b > a && b <= c) || (b > c && b < a))
        {
            Console.WriteLine(b);
        }
        if ((c > b && c <= a) || (c > a && c < b))
        {
            Console.WriteLine(c);
        }
    }
}
