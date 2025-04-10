using System;
using Section;

class Program
{
    static void Main()
    {
        Console.WriteLine("Программа для работы с отрезком на координатной прямой.");
        Console.WriteLine("\nВы хотите ввести отрезок вручную (1) или сгенерировать случайно (2)?");
        string segmentChoice = Console.ReadLine();

        double x, y;

        if (segmentChoice == "2")
        {
            x = RandomGenerator.GenerateDouble(-10, 10);
            y = RandomGenerator.GenerateDouble(-10, 10);
            Console.WriteLine($"Случайно сгенерированный отрезок: [{x:F3}, {y:F3}]");
        }
        else
        {
            x = DoubleInputReader.ReadDouble("Введите координату начала отрезка (x.xxx): ");
            y = DoubleInputReader.ReadDouble("Введите координату конца отрезка (y.yyy): ");
        }

        LineSegment segment = new LineSegment(x, y);
        Console.WriteLine($"\nСоздан отрезок: {segment}");

        string input;
        do
        {
            Console.WriteLine("\nВведите команду:");
            Console.WriteLine("!       — длина отрезка");
            Console.WriteLine("++      — увеличить координаты");
            Console.WriteLine("int     — приведение к int (X)");
            Console.WriteLine("double  — приведение к double (Y)");
            Console.WriteLine("+       — прибавить число");
            Console.WriteLine("?       — проверить попадание точки");
            Console.WriteLine("print   — вывести отрезок");
            Console.WriteLine("exit    — выход");

            Console.Write("\n> ");
            input = Console.ReadLine();

            switch (input)
            {
                case "!":
                    Console.WriteLine($"Длина отрезка: {!segment:F3}");
                    break;

                case "++":
                    segment++;
                    Console.WriteLine($"После ++: {segment}");
                    break;

                case "int":
                    int xAsInt = (int)segment;
                    Console.WriteLine($"Приведение к int (X): {xAsInt}");
                    break;

                case "double":
                    double yAsDouble = segment;
                    Console.WriteLine($"Приведение к double (Y): {yAsDouble:F3}");
                    break;

                case "+":
                    int d = (int)DoubleInputReader.ReadDouble("Введите целое число для прибавления: ");
                    segment = segment + d;
                    Console.WriteLine($"Новый отрезок: {segment}");
                    break;

                case "?":
                    double point = DoubleInputReader.ReadDouble("Введите точку: ");
                    Console.WriteLine(segment.Contains(point)
                        ? "Точка входит в отрезок."
                        : "Точка НЕ входит в отрезок.");
                    break;

                case "print":
                    Console.WriteLine($"Текущий отрезок: {segment}");
                    break;

                case "exit":
                    Console.WriteLine("Выход из программы...");
                    break;

                default:
                    Console.WriteLine("Неизвестная команда. Повторите ввод.");
                    break;
            }

        } while (input != "exit");
    }
}