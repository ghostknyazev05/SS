using System;

namespace GeometryNamespace
{
    // Класс проверки корректности выбора мода работы программы
    public static class InputValidator
    {
        // Метод проверки корректности введенных данных 
        public static int GetValidInput(string prompt)
        {
            int mode;
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out mode) && (mode == 1 || mode == 2))
                {
                    return mode; // Возвращаем корректный ввод
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите 1 или 2."); // Сообщение об ошибке
                }
            }
        }
    }
}
