using System;

namespace squareCount
{
    class Program
    {
        // программа считающая максимальное количество квадратов вписанных в прямоугольник 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону прямоугольника A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону прямоугольника B");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата С");
            int C = Convert.ToInt32(Console.ReadLine());
            int rectangleLength = 0, rectangleWidth = 0, widthCount = 0, squareCount = 0;
            while (rectangleLength < A && A - rectangleLength >= C)
            {
                while (rectangleWidth < B && B - rectangleWidth >= C)
                {
                    rectangleWidth = rectangleWidth + C;
                    widthCount++;
                }
                rectangleLength = rectangleLength + C;
                squareCount += widthCount;
            }
            Console.WriteLine("Количество квадратов вписанных в прямоугольник: {0}", squareCount);
            Console.ReadKey();
        }
    }
}
