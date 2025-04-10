using System;

namespace GeometryNamespace
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            // Приветственное сообщение и выбор режима работы с классом BaseClass
            Console.WriteLine("Программа демонстрирует работу с классами BaseClass и Point3D. Поиск максимальной цифры среди чисел");
            Console.WriteLine("Выберите режим для BaseClass:");

            int modeBaseClass = InputValidator.GetValidInput("1 - Ввести значения вручную\n2 - Сгенерировать случайные значения");

            double x, y, z;

            // Получение координат в зависимости от выбранного режима
            if (modeBaseClass == 1)
            {
                (x, y, z) = InputHandler.GetInputFromUser();
            }
            else
            {
                (x, y, z) = RandomGenerator.GenerateRandomValues();
            }

            // Создание объекта BaseClass и его копии
            Console.WriteLine("\nСоздание объекта BaseClass и его копии:");
            BaseClass baseObj = new BaseClass(x, y, z);
            BaseClass baseCopy = new BaseClass(baseObj);

            // Вывод информации о базовом классе и его копии
            Console.WriteLine("\nBaseClass:");
            baseObj.Print();
            Console.WriteLine("\nКопия BaseClass:");
            baseCopy.Print();

            // Вычисление максимальной последней цифры из полей объекта
            Console.WriteLine("\nВычисление максимальной последней цифры из полей:");
            int maxDigit = baseObj.GetMaxLastDigit();
            Console.WriteLine($"Максимальная последняя цифра: {maxDigit}");

            // Переход к работе с дочерним классом Point3D
            Console.WriteLine("\nТеперь начинается работа с дочерним классом Point3D.");
            Console.WriteLine("Выберите режим для Point3D:");
            Console.WriteLine("1 - Ввести значения вручную");
            Console.WriteLine("2 - Сгенерировать случайные значения");

            // Чтение выбора пользователя для Point3D
            int modePoint3D = int.Parse(Console.ReadLine() ?? "1");

            // Получение координат в зависимости от выбранного режима для Point3D
            if (modePoint3D == 1)
            {
                (x, y, z) = InputHandler.GetInputFromUser();
            }
            else
            {
                (x, y, z) = RandomGenerator.GenerateRandomValues();
            }

            // Создание объекта Point3D и его копии
            Point3D point = new Point3D(x, y, z);
            Point3D pointCopy = new Point3D(point);

            // Вывод информации о Point3D и его копии
            Console.WriteLine("\nPoint3D:");
            point.Print();
            Console.WriteLine("\nКопия Point3D:");
            pointCopy.Print();

            // Вычисление расстояния от точки до начала координат
            Console.WriteLine("\nВычисление расстояния до начала координат:");
            Console.WriteLine("Расстояние: " + point.DistanceToOrigin());

            // Проверка, находится ли точка на оси X
            Console.WriteLine("\nПроверка, находится ли точка на оси X:");
            Console.WriteLine(point.IsOnXAxis() ? "Да, точка лежит на оси X." : "Нет, точка не на оси X.");

            // Вычисление угла между вектором точки и осью Z
            Console.WriteLine("\nВычисление угла между вектором точки и осью Z:");
            double angle = point.CalculateAngleWithZAxis(); // Получение угла
            Console.WriteLine($"Угол между точкой и осью Z: {angle:F2} градусов");
        }
    }
}
