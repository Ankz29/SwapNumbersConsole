using System;
using SwapNumbersConsole;

namespace SwapNumbersConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st number: ");
            int value1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the 2nd number: ");
            int value2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("The entered 1st value is: " + value1 + "\n" + "The entered 2nd value is: " + value2+"\n");

            var SwappedNumbers = SwapUtility.SwapNumbers(value1, value2);

            Console.Write(  SwappedNumbers);
            Console.ReadLine();
        }
    }
}
