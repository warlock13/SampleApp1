using System;   // импорт базовых классов
// testing gitpush
namespace SampleApp1    // объявление пространства имен для решения SampleApp1
{   // Начало тела объявления пространства имен

    enum operation // перечисление операций модуля "Калькулятор"
    {   // начало перечисления
        Add = 1, // элементы перечисления
        Sub = 2, // нумерация начинается с 1, а не 0
        Mul = 3,
        Div = 4,
        And = 5,
        Or = 6,
        Xor = 7,
        Factorial = 8,
        SumArray = 9
    }   // конец перечисления

    class Program   // инициализация главного класса
    {   // начало тела класса 
        static readonly string errorMessage = "Incorrect input data";   // поле для чтения
        static void Main(string[] args) // реализация запускающего метода Main
        {   // начало тела метода Main
            const string TITLE = "RobCo Industries";    // пример константы
            Memory m = new Memory(); // выделили память под объект "Память"
            Calculator calc = new Calculator(TITLE, m); // инициализация экземпляра класса Calculator
            var menu = calc.GetName() +    // инициализация string-переменной
                "\n1 - Add" +               // строка
                "\n2 - Sub" +               // фрагментирована
                "\n3 - Mul" +               // для
                "\n4 - Div" +               // улучшения
                "\n5 - And" +               // визуального 
                "\n6 - Or" +                // восприятия
                "\n7 - Xor" +
                "\n8 - Factorial" +
                "\n9 - SumArray" +
                "\nC - Clear screen" +  
                "\nM - Print Memory" +
                "\nQ - Exit\n";             
            Console.WriteLine(menu);    // вывод в консоль текстового меню
            while (true)    // цикл с предусловием (бесконечный, т.к. внутри тела есть точка выхода)
            {   // начало тела цикла
                var key = Console.ReadLine() + "";  // ввод данных с клавиатуры и запись в переменную
                key = key.ToUpper();    // перевод входных данных в верхний регистр

                if (key.Equals("Q"))    // закрыть приложение, если введено "Q"
                {   // начало тела логического оператора
                    Environment.Exit(0);    // завершить выполнение программы с кодом 0
                }   // конец тела логического оператора
                else if (key.Equals("C"))   // проверка альтернативного логического условия
                {   // начало тела логического условия
                    Console.Clear();    // очистить консоль
                    Console.WriteLine(menu);    // вывести в консоль текст меню
                }   // коцен тела логического условия
                else if (key.Equals("M"))   // проверка альтернативного логического условия
                {   // начало тела логического условия
                    Console.WriteLine("Memory:"); // вывод строки в консоль
                    if (m.IsEmpty()) Console.WriteLine("<empty>");
                    m.PrintMemory();    // вывести в консоль состояние памяти
                }   // коцен тела логического условия
                else  // при невыполнении вышеперечисленных условий 
                {   // начало тела блока else
                    int intKey; // инициализация int-ключа для оператора switch
                    try { intKey = int.Parse(key); }    // попытка преобразовать string -> int
                    catch { intKey = -1; }  // формирование признака наличия ошибки
                    switch (intKey)    // оператор выбора
                    {   // начало тела оператора switch
                        case (int)operation.Add:   // сценарий, если было введено "1"
                            var tuple = calc.GetIntOperands();
                            if (tuple.Item3)
                                Console.WriteLine("Ans = " + calc.Add(tuple.Item1, tuple.Item2) + "\n");
                            else Console.WriteLine(errorMessage);
                            break;  // выход из тела оператора switch
                        case (int)operation.Sub:   // сценарий, если было введено "2"
                            tuple = calc.GetIntOperands();
                            if (tuple.Item3)
                                Console.WriteLine("Ans = " + calc.Sub(tuple.Item1, tuple.Item2) + "\n");
                            else Console.WriteLine(errorMessage);
                            break;  // выход из тела оператора switch
                        case (int)operation.Mul:   // сценарий, если было введено "3"
                            tuple = calc.GetIntOperands();  // инициализация кортежа
                            if (tuple.Item3)    // если признак ошибки отсутствует
                                // вывести в консоль результат вычисления
                                Console.WriteLine("Ans = " + calc.Mul(tuple.Item1, tuple.Item2) + "\n");
                            else Console.WriteLine(errorMessage); // иначе сообщение об ошибке
                            break;  // выход из тела оператора switch
                        case (int)operation.Div:   // сценарий, если было введено "4"
                            var tupleDouble = calc.GetDoubleOperands(); // инициализация котрежа
                            if (tupleDouble.Item3)  // если признак ошибки отсутствует
                                // вывести в консоль результат вычисления
                                Console.WriteLine("Ans = " + calc.Div(tupleDouble.Item1, tupleDouble.Item2) + "\n");
                            else Console.WriteLine(errorMessage); // иначе сообщение об ошибке
                            break;  // выход из тела оператора 
                        case (int)operation.Or: // если было введено "6"
                            tuple = calc.GetIntOperands(); // инициализация кортежа
                            if (tuple.Item3)  // если признак ошибки отсутствует
                                // вывести в консоль результат вычисления
                                Console.WriteLine("Ans = " + calc.Or(tuple.Item1, tuple.Item2) + "\n");
                            else Console.WriteLine(errorMessage);
                            break;  // выход из тела оператора switch
                        case (int)operation.And:    // если было введено "5"
                            tuple = calc.GetIntOperands();  // ввод с клавиатуры int-операторов
                            if (tuple.Item3)  // если признак ошибки отсутствует
                                // вывести в консоль результат вычисления
                                Console.WriteLine("Ans = " + calc.And(tuple.Item1, tuple.Item2) + "\n");
                            else Console.WriteLine(errorMessage); // иначе сообщение об ошибке
                            break;  // выход из тела оператора switch
                        case (int)operation.Xor:    // если было введено "7"
                            tuple = calc.GetIntOperands(); // кортеж
                            if (tuple.Item3)  // если признак ошибки отсутствует
                                // вывести в консоль результат вычисления
                                Console.WriteLine("Ans = " + calc.Xor(tuple.Item1, tuple.Item2) + "\n");
                            else Console.WriteLine(errorMessage); // сообщение об ошибке
                            break;  // выход из тела оператора switch
                        case (int)operation.Factorial:  // если было введено "8"
                            var tupleSingle = calc.GetSingleOperator(); // ввод N с клавиатуры
                            if (tupleSingle.Item2)  // если признак ошибки отсутствует
                                // вывести в консоль результат вычисления
                                Console.WriteLine($"Factorial({tupleSingle.Item1}) = "
                                    + calc.Factorial(tupleSingle.Item1, true) + "\n");
                            else Console.WriteLine(errorMessage); // иначе ошибка
                            break;  // выход из тела оператора switch
                        case (int)operation.SumArray:   // если было введено "9"
                            var tupleArray = calc.GetArray();   // ввод массива с клавиатуры
                            if (tupleArray.Item2)  // если признак ошибки отсутствует
                                // вывести в консоль результат вычисления
                                Console.WriteLine("Sum of array = "
                                    + calc.SumArray(tupleArray.Item1) + "\n");
                            else Console.WriteLine(errorMessage); // иначе ошибка
                            break; // конец условия
                        default:    // если был введен символ, непредусмотренный консольным меню
                            Console.WriteLine($"The [{key}] key was triggered\n"); // вывод необработанного запроса меню
                            break;  // выход из тела оператора switch
                    }   // конец тела оператора switch
                }   // конец тела блока else
            }   // конец тела цикла
            
        }   // конец тела метода Main
        
    }   // конец тела класса Program
}   // конец тела объявления пространства имен
