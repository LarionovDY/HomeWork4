using System;

namespace numberSequence
{
    class Program
    {
        // программа сравнивающая количество отрицательных и положительных чисел во введенной последовательности 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность состоящую из целочисленных положительных и отрицательных значений");
            Console.WriteLine("После ввода каждого значения нажмите enter");
            Console.WriteLine("Для окончания ввода введите 0");
            uint posNumberCount = 0, negNumberCount = 0;
            int number = 0;
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number > 0)
                {
                    posNumberCount++;
                }
                else if (number < 0)
                {
                    negNumberCount++;
                }
            } while (number != 0);
            if (posNumberCount == negNumberCount)
            {
                Console.WriteLine("Во введенной последовательности количество отрицательных и положительных чисел равно и составляет: {0}", posNumberCount);
            }
            else
            {
                Console.WriteLine("Во введенной последовательности больше {0} чисел, количество отрицательных чисел: {1}, положительных чисел: {2}", posNumberCount > negNumberCount ? "положительных" : "отрицательных", negNumberCount, posNumberCount);
            }
            Console.ReadKey();
        }
    }
}
