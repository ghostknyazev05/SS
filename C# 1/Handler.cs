using System;

namespace GeometryNamespace
{
    // Класс для ввода чисел вручную 
    public static class InputHandler
    {
        // Метод ввода чисел с клавиатуры 
        public static (double, double, double) GetInputFromUser()
        {
            double x = GetValidDouble("Введите X: ");
            double y = GetValidDouble("Введите Y: ");
            double z = GetValidDouble("Введите Z: ");
            return (x, y, z);
        }

        // Метод проверки корректности введенных данных 
        private static double GetValidDouble(string message)
        {
            double result;
            Console.Write(message);
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("Ошибка ввода. Попробуйте снова: ");
            }
            return result;
        }
    }
}