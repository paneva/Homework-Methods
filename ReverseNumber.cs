using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Reverse_Number
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            double Number = double.Parse(Console.ReadLine());
            double reversed = GetReversedNumber(Number);
            Console.WriteLine("Reversed number is "+reversed);
        }
        static double GetReversedNumber(double Number)
        {
            string NumberAsString = Number.ToString();
            char[] charArray = NumberAsString.ToCharArray();
            Array.Reverse(charArray);
            string ReversedNumberAsString =new string( charArray);
            double ReversedNumber = double.Parse(ReversedNumberAsString);
            return ReversedNumber;
        }
    }
}
