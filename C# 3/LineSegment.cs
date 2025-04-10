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
            double min = Math.Min(_x, _y);
            double max = Math.Max(_x, _y);
            return point >= min && point <= max;
        }

        public override string ToString()
        {
            return $"Отрезок: [{_x:F3}, {_y:F3}]";
        }

        // Унарный оператор ! — вычисление длины отрезка
        public static double operator !(LineSegment segment)
        {
            return Math.Abs(segment._y - segment._x);
        }

        // Унарный оператор ++ — увеличение координат отрезка на 1
        public static LineSegment operator ++(LineSegment segment)
        {
            segment._x += 1;
            segment._y += 1;
            return segment;
        }

        // Явное приведение к int — вернуть целую часть X
        public static explicit operator int(LineSegment segment)
        {
            return (int)segment._x;
        }

        // Неявное приведение к double — вернуть Y
        public static implicit operator double(LineSegment segment)
        {
            return segment._y;
        }

        // Бинарный оператор + (увеличивает обе координаты на d)
        public static LineSegment operator +(LineSegment segment, int d)
        {
            return new LineSegment(segment._x + d, segment._y + d);
        }

        // Перегрузка обратного + (int + LineSegment)
        public static LineSegment operator +(int d, LineSegment segment)
        {
            return new LineSegment(segment._x + d, segment._y + d);
        }
    }
}