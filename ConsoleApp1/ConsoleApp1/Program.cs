using System;
using System.Security.Cryptography;

public class HelloWorld
{
    static int p1 = 0, p2 = 1, p3;
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter numbr");
        int num = Convert.ToInt32(Console.ReadLine());
        int space = num-1;
        int len = 1;
        for (int i = 1; i <= num; i++)
        {
            for(int r = 1; r <= space; r++)
            {
                Console.Write(" ");
            }
            
            for(int j = 1; j <= len; j++)
            {
                Console.Write("*");
            }
            space--;
            len = len + 2;
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}