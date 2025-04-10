using Section;

class Program
{
    static void Main()
    {
        Console.WriteLine("Программа для работы с отрезком на координатной прямой.");


        Console.WriteLine("\nВы хотите ввести отрезок вручную (1) или сгенерировать случайный (2)?");
        string segmentChoice = Console.ReadLine();

        double x = 0, y = 0;

        if (segmentChoice == "2")
        {

            x = RandomGenerator.GenerateDouble(-10, 10);
            y = RandomGenerator.GenerateDouble(-10, 10);
            Console.WriteLine($"Случайно сгенерированный отрезок: [{x}, {y}]");
        }
        else
        {

            x = DoubleInputReader.ReadDouble("Введите координату начала отрезка (x): ");
            y = DoubleInputReader.ReadDouble("Введите координату конца отрезка (y): ");
        }


        LineSegment segment = new LineSegment(x, y);
        Console.WriteLine("Отрезок создан:");
        Console.WriteLine(segment.ToString());


        Console.WriteLine("\nВы хотите ввести точку вручную (1) или сгенерировать случайную (2)?");
        string pointChoice = Console.ReadLine();

        double point;

        if (pointChoice == "2")
        {
            point = RandomGenerator.GenerateDouble(Math.Min(x, y) - 10, Math.Max(x, y) + 10);
            Console.WriteLine($"Случайно сгенерированная точка: {point:F2}");
        }
        else
        {
            point = DoubleInputReader.ReadDouble("Введите координату точки для проверки: ");
        }


        Console.WriteLine($"Проверка: попадает ли точка {point} в отрезок...");
        bool result = segment.Contains(point);


        Console.WriteLine(result
            ? "Результат: точка попадает в отрезок."
            : "Результат: точка НЕ попадает в отрезок.");
    }
}