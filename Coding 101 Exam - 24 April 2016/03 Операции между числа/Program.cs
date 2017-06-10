using System;

namespace _03_Операции_между_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            int awnser1 = Math.Abs(N1 + N2);
            int awnser2 = Math.Abs(N1 - N2);
            int awnser3 = N1 * N2;
            int awnser4 = N1 / N2;
            int awnser5 = N1 % N2;
            int awnser6 = N2 / 0;
            if (symbol == "+" && awnser1 % 2 == 0)
            {

                Console.WriteLine("{0} {1} {2} = {3} - even", N1, symbol, N2, awnser1);
            }
            else if (symbol == "+" && awnser1 % 2 != 0)
            {

                Console.WriteLine("{0} {1} {2} = {3} - odd", N1, symbol, N2, awnser1);
            }
            else if (symbol == "-" && awnser2 % 2 != 0)
            {

                Console.WriteLine("{0} {1} {2} = {3} - odd", N1, symbol, N2, awnser2);
            }
            else if (symbol == "-" && awnser2 % 2 == 0)
            {

                Console.WriteLine("{0} {1} {2} = {3} - even", N1, symbol, N2, awnser2);
            }
            if (symbol == "*" && awnser3 % 2 == 0)
            {

                Console.WriteLine("{0} {1} {2} = {3} - even", N1, symbol, N2, awnser3);
            }
            else if (symbol == "*" && awnser3 % 2 != 0)
            {

                Console.WriteLine("{0} {1} {2} = {3} - odd", N1, symbol, N2, awnser3);
            }
            else if (symbol == "/")
            {
                Console.WriteLine("{0} {1} {2} = {3:f2}", N1, symbol, N2, awnser4);
            }
            else if (symbol == "%")
            {
                Console.WriteLine("{0} {1} {2} = {3}", N1, symbol, N2, awnser5);
            }
            else if (awnser6 == 0 || awnser6  == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", N2);
            }
        }
    }
}
