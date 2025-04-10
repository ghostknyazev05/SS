
using System;

namespace GeometryNamespace
{

    public static class RandomGenerator
    {
        public static (double, double, double) GenerateRandomValues()
        {
            Random rnd = new Random();
            double x = rnd.Next(-100, 100);
            double y = rnd.Next(-100, 100);
            double z = rnd.Next(-100, 100);
            Console.WriteLine($"Случайные значения: X = {x}, Y = {y}, Z = {z}");
            return (x, y, z);
        }
    }
}