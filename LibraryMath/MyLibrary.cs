using System;

namespace LibraryMath
{
    public class MyLibrary
    {
        static public double SquareCircle (double Radius)
        {
            double SquareC = -1; // вернет отрицательное значения в случае ошибки
            if (Radius == 0) //Проверочки.)
                Console.WriteLine("Радиус равен нулю");
            else if (Radius < 0)
                Console.WriteLine("Введены отрицательные значения");
            else
               SquareC = Math.Round(Math.PI * Math.Pow(Radius,2), 4);//получаем число и сразу округляем до 4 цифр после запятой
            return SquareC;
        }
        static public double SquareTriangle (double a, double b, double c)
        {
            double SquareT = -1; // вернет отрицательное значения в случае ошибки
            if (a < 0 || b < 0 || c < 0)
                Console.WriteLine("Введены отрицательные значения");
            else if (a == 0 || b == 0 || c == 0)
                Console.WriteLine("Введен 0");
            else
            {
                double p = (a + b + c) / 2; // находим полупериметр
                if (p <= 0 || (p - c) <= 0 || (p - b) <= 0 || (p - a) <= 0)
                    Console.WriteLine("Такого треугольника не существует!");
                else 
                    SquareT = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 4);
            }
            return SquareT; 
        }
    }
}
