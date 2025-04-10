namespace Section
{
    using System;

    public static class RandomGenerator
    {
        // Экземпляр генератора 
        public static Random random = new Random();

        // Метод для генерации случайных чисел
        public static double GenerateDouble(double min, double max)
        {
            double value = min + (max - min) * random.NextDouble();
            return Math.Round(value,3);
        }

    }
}