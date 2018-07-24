namespace SampleApp1    // область пространства имен
{   // начало области простанства имен
    public class Counter    // описание класса
    {   // начало класса
        public int Value { get; set; } = 0; // свойства класса
        public static Counter operator ++(Counter c1) // перегрузка оператора инкремента
        {   // начало тела перегрузки
            return new Counter { Value = c1.Value + 1 };    // возвращение результата перегрузки
        }   // конец тела перегрузки
        public virtual void Display()
        {
            System.Console.WriteLine($"counter = {Value}");
        }
    }   // конец класса
}   // конец области простанства имен
