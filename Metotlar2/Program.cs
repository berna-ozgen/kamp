using System;

namespace Metotlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Console.WriteLine(Add2(5,15));

            int number1 = 50;
            int number2 = 100;
            var result2 = Add3(ref number1, number2);

            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.WriteLine(Multiply(2,3));
            Console.WriteLine(Multiply(2,3,4));


        }
        static void Add()
        {
            Console.WriteLine("Add");
        }
        static int Add2(int say1,int say2=40)
        {
           var result= say1 + say2;
            return result;
        }
        static int Add3(ref int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int  Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1,int number2,int number3)
        {
            return number1 * number2 * number3;
        }
    }
}
