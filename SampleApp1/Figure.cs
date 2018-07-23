using System;   // импорт базовых классов

namespace SampleApp1    // область пространства имен
{   // начало пространства имен
    internal abstract class Figure  // описание абстрактного класса Фигура
    {   // начало описания класса
        public abstract double Perimeter(); // свойство периметр
        public abstract double Square();    // свойство площадь
        public virtual string ToString()    // виртуальный метод, 
        // представляющий описание фигуры в строковом виде
        {   // начало метода
            // подсчет свойств и формирование их описания в виде строки
            string res = $"Type:      {this.GetType().Name}" +
                $"\nPerimeter: {this.Perimeter()}" +
                $"\nSquare:    {this.Square()}";
            return res; // возвращение сформированного описания
        }   // конец метода

    }   // конец описание класса

    internal class Rectangle : Figure   // класс параллелограмм
    {   // начало класса
        public double Height { get; set; }  // св-во высота
        public double Width { get; set; }   // св-во ширина
        public override double Perimeter()  // вычисление периметра
        {   // начало метода
            return 2 * (Height + Width);    // возвращение результата
        }   // конец метода
        public override double Square() // вычисление площади
        {   // начало метода
            return Height * Width;  // возвращение результата
        }   // конец метода
    }   // конец класса

    internal class Quadrate : Figure    // класс квадрат
    {   // начало класса
        public double Edge { get; set; }    // св-во сторона
        public override double Perimeter()  // вычисление периметра
        {   // начало метода
            return 4 * Edge;
        }   // конец метода
        public override double Square() // вычисление площади
        {   // начало метода
            return Math.Pow(Edge, 2);   // возвращение результата
        }   // конец метода
    }   // конец класса

    internal class Circle : Figure  // класс Окружность
    {   // начало класса
        public double Radius { get; set; }  // св-во Радиус
        public override double Perimeter()  // вычисление периметра
        {   // начало метода
            return (2 * Math.PI * Radius);  // возвращение результата
        }   // конец метода
        public override double Square() // вычисление площади
        {   // начало метода
            return (Math.PI * Math.Pow(Radius, 2)); // возвращение результата
        }   // конец метода
    }   // конец класса
}   // конец пространства имен
