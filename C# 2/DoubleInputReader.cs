namespace Section
{
    using System;

    public static class DoubleInputReader
    {
        // Метод для ввода чисел и проверка
        public static double ReadDouble(string promt)
        {
            double value;
            string input;

            Console.WriteLine(promt);
            input = Console.ReadLine();

            while (!InputValidator.isValidDouble(input, out value))
            {
                Console.WriteLine("Ошибка: введите корректное число: :");
                input = Console.ReadLine();
            }
            return value;
        }
    }
}