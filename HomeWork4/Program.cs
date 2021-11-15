using System;

namespace sqr
{
    class Program
    {
        // программа численно высчитывающая квадрат введенного числа
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число, квадрат которого хотели бы посчитать: ");
            uint number = Convert.ToUInt32(Console.ReadLine());
            uint sqrNumber = 0;
            for (uint i = 1; i <= number; i++)
            {
                uint sqrCount = 2 * i - 1;
                sqrNumber += sqrCount;
                Console.WriteLine("Квадрат числа {0} : {1}: ", i, sqrNumber);
            }
            Console.WriteLine("Квадрат введенного числа {0} : {1} ", number, sqrNumber);
            Console.ReadKey();
        }
    }
}
