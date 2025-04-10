using System;

namespace GeometryNamespace
{
    public class BaseClass
    {
        // Создание защищенных полей, которые могут быть использованы в этом или производных от базового класса
        protected double field1;
        protected double field2;
        protected double field3;

        // Метод инициализации переменных значениями
        public BaseClass(double a, double b, double c)
        {
            field1 = a;
            field2 = b;
            field3 = c;
        }

        // Метод копирования значений
        public BaseClass(BaseClass other)
        {
            field1 = other.field1;
            field2 = other.field2;
            field3 = other.field3;
        }

        // Метод получения последних цифр чисел
        public virtual int GetMaxLastDigit()
        {
            int last1 = Math.Abs((int)field1) % 10;
            int last2 = Math.Abs((int)field2) % 10;
            int last3 = Math.Abs((int)field3) % 10;
            return Math.Max(last1, Math.Max(last2, last3));
        }

        public override string ToString()
        {
            return $"BaseClass поля: field1 = {field1}, field2 = {field2}, field3 = {field3}";
        }

        // Метод Print для вывода информации о базовом классе
        public virtual void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}