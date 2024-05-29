using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
            Console.Write("/");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("-");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("\\");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("|");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b");
    }
}
