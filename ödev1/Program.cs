using System;

namespace ödev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result = Add2(10, 15);
            Console.WriteLine(result);
            Console.ReadLine();
            

        }
        static void Add()
        {
            Console.WriteLine("Added!);
            }
        static int Add2(int num1,int num2)
        {
            return num1 + num2;
        }
    }
}
