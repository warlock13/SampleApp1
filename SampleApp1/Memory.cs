using System;   // импорт базовых классов
using System.Collections.Generic;   // импорт коллекций
using System.Linq; // импорт классов и интерфейсов System.Linq

namespace SampleApp1    // область пространства имен
{   // начало области пространства имен
    public static class Memory // описание класса
    {   // начало класса
        
        private static List<string> memory = new List<string>();    // объявление коллекции
        public static Counter counter = new Counter();  // создание объекта-счетчика

        public static string List   // сеттер для рабочей коллекции
        {   // начало определения свойства
            set { memory.Add(value); counter++; }   // описание сеттера
        }   // конец определения свойства

        public static Boolean IsEmpty() // проверка на пустоту коллекции
        {   // начало функции
            if (memory.Count() == 0) return true;   // если пустая, то true
            else return false;  // иначе false
        }   // конец функции

        public static void PrintMemory()    // вывод в консоль коллекции
        {   // начало процедуры
            foreach (var item in memory)    // цикл для работы с коллекцией
            {   // начало цикла
                Console.WriteLine(item);    // вывод в консоль записи
            }   // конец цикла
            // вывод в консоль счетчика успешно выполненный операций
            Console.WriteLine($"Operations done: {counter.Value}");
        }   // конец процедуры

    }   // конец класса
}   // конец области пространства имен
