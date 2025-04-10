using System;

namespace Section
{
    public class LineSegment
    {
        private double _x;
        private double _y;

        // Свойства для доступа к координатам 
        public double X { get => _x; }
        public double Y { get => _y; }

        // Конструктор
        public LineSegment(double x, double y)
        {
            if (x < y)
            {
                _x = x;
                _y = y;
            }
            else
            {
                _x = y;
                _y = x;
            }
        }

        // Проверка, попадает ли точка в отрезок
        public bool Contains(double point)
        {
            double min = Math.Min(x, y);
            double max = Math.Max(x, y);
            return point >= min && point <= max;
        }
        // Перегрузка ToString() для отображения отрезка
        public override string ToString()
        {
            return $"Отрезок: [{_x}; {_y}]";
        }
    }
}