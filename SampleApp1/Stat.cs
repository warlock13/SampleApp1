namespace SampleApp1    // область пространства имен
{   // начало пространства имен
    public class Stat : Counter // описание класа потомка от базового Counter
    {   // начало класса
        public int IterationsPassed { get; set; }   // св-во "итераций выполнено"
        public int ErrorsOccured { get; set; }      // св-во "ошибок обработано"
        public int ScreenCleared { get; set; }      // св-во "очисток экрана выполнено"

        public override void Display()  // перегруженный метод, который выводит в консоль
                                        // текущее состояние всех счетчиков
        {   // начало тела процедуры
            System.Console.WriteLine(   // оператор вывода в консоль строки
                $"Iterations executed: {IterationsPassed}" +    // составная строка
                $"\nErrors occured:      {ErrorsOccured}" +     // продолжение составной строки
                $"\nScreen cleared:      {ScreenCleared}"       // продолжение составной строки
                );  // конец оператора вывода в консоль
        }   // конец тела процедуры
        
    }   // конец класса
}   // конец пространства имен
