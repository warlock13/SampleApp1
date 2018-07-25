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
        SumArray = 9,
        Days = 10,
        Years = 11,
        Geometry = 12
    }   // конец перечисления

    public delegate void Print(string message);

    class Program   // инициализация главного класса
    {   // начало тела класса 
        public static void Display(string message)
        {
            Console.WriteLine(message);
        }
        static readonly string errorMessage = "Incorrect input data";   // поле для чтения
        static void Main(string[] args) // реализация запускающего метода Main
        {   // начало тела метода Main
            const string TITLE = "RobCo Industries";    // пример константы
            Print _del;
            string message = "";
            //Memory m = new Memory(); // выделили память под объект "Память"
            Calculator calc = new Calculator(TITLE); // инициализация экземпляра класса Calculator
            Period period = new Period();  // инициализацая экземпляра класса Period
            Stat stat = new Stat();
            string menu = calc.GetName() +    // инициализация string-переменной
                "\n1 - Add" +               // строка
                "\n2 - Sub" +               // фрагментирована
                "\n3 - Mul" +               // для
                "\n4 - Div" +               // улучшения
                "\n5 - And" +               // визуального 
                "\n6 - Or" +                // восприятия
                "\n7 - Xor" +
                "\n8 - Factorial" +
                "\n9 - SumArray" +
                "\n10 - Days to years" +
                "\n11 - Years to days" +
                "\n12 - Geometry" +
                "\nP - Feed the pet" +
                "\nC - Clear screen" +
                "\nM - Print Memory" +
                "\nS - Show statictics" +
                "\nQ - Exit\n";             
            Console.WriteLine(menu);    // вывод в консоль текстового меню
            while (true)    // цикл с предусловием (бесконечный, т.к. внутри тела есть точка выхода)
            {   // начало тела цикла
                ++stat.IterationsPassed;
                var key = Console.ReadLine() + "";  // ввод данных с клавиатуры и запись в переменную
                key = key.ToUpper();    // перевод входных данных в верхний регистр

                if (key.Equals("Q"))    // закрыть приложение, если введено "Q"
                {   // начало тела логического оператора
                    Environment.Exit(0);    // завершить выполнение программы с кодом 0
                }   // конец тела логического оператора
                else if (key.Equals("C"))   // проверка альтернативного логического условия
                {   // начало тела логического условия
                    Console.Clear();    // очистить консоль
                    stat.ScreenCleared++;
                    Console.WriteLine(menu);    // вывести в консоль текст меню
                }   // коцен тела логического условия
                else if (key.Equals("M"))   // проверка альтернативного логического условия
                {   // начало тела логического условия
                    Console.WriteLine("Memory:"); // вывод строки в консоль
                    if (Memory.IsEmpty()) Console.WriteLine("<empty>");
                    Memory.PrintMemory();    // вывести в консоль состояние памяти
                }   // коцен тела логического условия
                else if (key.Equals("S"))   // проверка альтернативного логического условия
                {   // начало тела логического условия
                    stat.Display(); // вывод состояние счетчиков в консоль
                }   // конец тела логического условия
                else if (key.Equals("P"))   // проверка альтернативного логического условия
                {   // начало тела логического условия
                    Console.WriteLine(
                    "1 - Call for cat\n" +
                    "2 - Call for mouse\n" +
                    "3 - Call for bird\n" +
                    "Any key to cancel"
                    );
                    key = Console.ReadLine();
                    int intKey; // инициализация int-ключа для оператора switch
                    try { intKey = int.Parse(key); }    // попытка преобразовать string -> int
                    catch { intKey = -1; }  // формирование признака наличия ошибки
                    switch (intKey) // переключатель условий
                    {   // начало switch
                        case 1: // выбрали кота
                            Console.Write("Enter the name of cat you want to call: ");  // запрос клички питомца
                            Cat cat = new Cat { Name = Console.ReadLine() };    // вводи клички с клавиатуры
                            Console.WriteLine(
                                $"The cat {cat.Name} is here and it wants to eat some {cat.Eats()}"
                                );  // вывод с консоль сообщения об инициализации
                            Console.Write("Give it some <food_name>: ");    // запрос названия еды
                            string str = cat.Feed(Console.ReadLine()) + $" and {cat.Moves()} to {cat.Lives()}";  // формирование рузультата
                            Memory.List = str;  // добавление результата в историю
                            Console.WriteLine(str); // вывод в консоль резлуьтата
                            break;  // конец case
                        case 2: // выбрали мышь
                            Console.Write("Enter the name of mouse you want to call: ");  // запрос клички питомца
                            Mouse mouse = new Mouse { Name = Console.ReadLine() };    // вводи клички с клавиатуры
                            Console.WriteLine(
                                $"The mouse {mouse.Name} is here and it wants to eat some {mouse.Eats()}"
                                );  // вывод с консоль сообщения об инициализации
                            Console.Write("Give it some <food_name>: ");    // запрос названия еды
                            str = mouse.Feed(Console.ReadLine()) + $" and {mouse.Moves()} to {mouse.Lives()}";   // формирование результата
                            Memory.List = str;  // добавление результата в историю
                            Console.WriteLine(str);    // вывод в консоль результата
                            break;  // конец case
                        case 3: // выбрали птичку
                            Console.Write("Enter the name of bird you want to call: ");  // запрос клички питомца
                            Bird bird = new Bird { Name = Console.ReadLine() };    // вводи клички с клавиатуры
                            Console.WriteLine(
                                $"The bird {bird.Name} is here and it wants to eat some {bird.Eats()}"
                                );  // вывод с консоль сообщения об инициализации
                            Console.Write("Give it some <food_name>: ");    // запрос названия еды
                            // вывод в консоль результата
                            str = bird.Feed(Console.ReadLine()) + $" and {bird.Moves()} to {bird.Lives()}";   // формирование результата
                            Memory.List = str;  // добавление результата в историю
                            Console.WriteLine(str);    // вывод в консоль результата
                            break;  // конец 
                        default:    // условие по-умолчанию
                            Console.WriteLine("canceled");  // сообщение об отмене
                            break;  // конец case
                        }   // конец switch
                }   // конец тела логического условия
                else  // при невыполнении вышеперечисленных условий 
                {   // начало тела блока else
                    int intKey; // инициализация int-ключа для оператора switch
                    try { intKey = int.Parse(key); }    // попытка преобразовать string -> int
                    catch { intKey = -1; }  // формирование признака наличия ошибки
                    switch (intKey)    // оператор выбора
                    {   // начало тела оператора switch
                        case (int)operation.Add:   // сценарий, если было введено "1"
                            var tuple = calc.GetDoubleOperands();
                            if (tuple.Item3)
                            //Console.WriteLine("Ans = " + calc.Add(tuple.Item1, tuple.Item2) + "\n");
                            {
                                message = "Ans = " + calc.Add(tuple.Item1, tuple.Item2) + "\n";
                                _del = Display;
                                if (_del != null) _del(message);
                            }
                            else { stat.ErrorsOccured++; Console.WriteLine(errorMessage); }
                            break;  // выход из тела оператора switch
                        case (int)operation.Sub:   // сценарий, если было введено "2"
                            tuple = calc.GetDoubleOperands();
                            if (tuple.Item3)
                            //Console.WriteLine("Ans = " + calc.Sub(tuple.Item1, tuple.Item2) + "\n");
                            {
                                message = "Ans = " + calc.Sub(tuple.Item1, tuple.Item2) + "\n";
                                _del = Display;
                                if (_del != null) _del(message);
                            }
                            else { stat.ErrorsOccured++; Console.WriteLine(errorMessage); }
                            break;  // выход из тела оператора switch
                        case (int)operation.Mul:   // сценарий, если было введено "3"
                            tuple = calc.GetDoubleOperands();  // инициализация кортежа
                            if (tuple.Item3)    // если признак ошибки отсутствует
                                                // вывести в консоль результат вычисления
                                                // Console.WriteLine("Ans = " + calc.Mul(tuple.Item1, tuple.Item2) + "\n");
                            {
                                message = "Ans = " + calc.Mul(tuple.Item1, tuple.Item2) + "\n";
                                _del = Display;
                                if (_del != null) _del(message);
                            }
                            else { stat.ErrorsOccured++; Console.WriteLine(errorMessage); } // иначе сообщение об ошибке
                            break;  // выход из тела оператора switch
                        case (int)operation.Div:   // сценарий, если было введено "4"
                            var tupleDouble = calc.GetDoubleOperands(); // инициализация котрежа
                            if (tupleDouble.Item3)  // если признак ошибки отсутствует
                                                    // вывести в консоль результат вычисления
                                                    //  Console.WriteLine("Ans = " + calc.Div(tupleDouble.Item1, tupleDouble.Item2) + "\n");
                            {
                                message = "Ans = " + calc.Div(tupleDouble.Item1, tupleDouble.Item2) + "\n";
                                _del = Display;
                                if (_del != null) _del(message);
                            }
                            else { stat.ErrorsOccured++; Console.WriteLine(errorMessage); } // иначе сообщение об ошибке
                            break;  // выход из тела оператора 
                        case (int)operation.Or: // если было введено "6"
                            var tupleInt = calc.GetIntOperands(); // инициализация кортежа
                            if (tupleInt.Item3)  // если признак ошибки отсутствует
                                                 // вывести в консоль результат вычисления
                                                 // Console.WriteLine("Ans = " + calc.Or(tupleInt.Item1, tupleInt.Item2) + "\n");
                            {
                                message = "Ans = " + calc.Or(tupleInt.Item1, tupleInt.Item2) + "\n";
                                _del = Display;
                                if (_del != null) _del(message);
                            }
                            else { stat.ErrorsOccured++; Console.WriteLine(errorMessage); }
                            break;  // выход из тела оператора switch
                        case (int)operation.And:    // если было введено "5"
                            tupleInt = calc.GetIntOperands();  // ввод с клавиатуры int-операторов
                            if (tupleInt.Item3)  // если признак ошибки отсутствует
                                                 // вывести в консоль результат вычисления
                                                 //Console.WriteLine("Ans = " + calc.And(tupleInt.Item1, tupleInt.Item2) + "\n");
                            {
                                message = "Ans = " + calc.And(tupleInt.Item1, tupleInt.Item2) + "\n";
                                _del = Display;
                                if (_del != null) _del(message);
                            }
                            else { stat.ErrorsOccured++; Console.WriteLine(errorMessage); } // иначе сообщение об ошибке
                            break;  // выход из тела оператора switch
                        case (int)operation.Xor:    // если было введено "7"
                            tupleInt = calc.GetIntOperands(); // кортеж
                            if (tupleInt.Item3)  // если признак ошибки отсутствует
                                                 // вывести в консоль результат вычисления
                                                 //Console.WriteLine("Ans = " + calc.Xor(tupleInt.Item1, tupleInt.Item2) + "\n");
                            {
                                message = "Ans = " + calc.Xor(tupleInt.Item1, tupleInt.Item2) + "\n";
                                _del = Display;
                                if (_del != null) _del(message);
                            }
                            else { stat.ErrorsOccured++; Console.WriteLine(errorMessage); } // сообщение об ошибке
                            break;  // выход из тела оператора switch
                        case (int)operation.Factorial:  // если было введено "8"
                            var tupleSingle = calc.GetSingleOperator(); // ввод N с клавиатуры
                            if (tupleSingle.Item2)  // если признак ошибки отсутствует
                                // вывести в консоль результат вычисления
                                //Console.WriteLine($"Factorial({tupleSingle.Item1}) = "
                                //    + calc.Factorial((int)tupleSingle.Item1, true) + "\n");
                            {
                                message = $"Factorial({tupleSingle.Item1}) = "
                                    + calc.Factorial((int)tupleSingle.Item1, true) + "\n";
                                _del = Display;
                                if (_del != null) _del(message);
                            }
                            else { stat.ErrorsOccured++; Console.WriteLine(errorMessage); } // иначе ошибка
                            break;  // выход из тела оператора switch
                        case (int)operation.SumArray:   // если было введено "9"
                            var tupleArray = calc.GetArray();   // ввод массива с клавиатуры
                            if (tupleArray.Item2)  // если признак ошибки отсутствует
                                // вывести в консоль результат вычисления
                                //Console.WriteLine("Sum of array = "
                                //    + calc.SumArray(tupleArray.Item1) + "\n");
                            {
                                message = "Sum of array = "
                                    + calc.SumArray(tupleArray.Item1) + "\n";
                                _del = Display;
                                if (_del != null) _del(message);
                            }
                            else { stat.ErrorsOccured++; Console.WriteLine(errorMessage); } // иначе ошибка
                            break; // конец условия
                        case (int)operation.Days:   // если было введено "10"
                            tupleSingle = calc.GetSingleOperator(); // ввод N с клавиатуры
                            if (tupleSingle.Item2)  // если признак ошибки отсутствует
                                                    // вывести в консоль результат вычисления
                            {   // начало логического условия
                                Day days = new Day { Days = (int)tupleSingle.Item1 };    // инициализация дней
                                period = days;  // перевод дней в года:месяцы:дни
                                // формирование строки-ответа
                                string res = $"Years: {period.Years} Months: {period.Months} Days: {period.Days}";
                                Memory.List = res;  // добавление в историю записи о вычислении
                                                    //Console.WriteLine($"{res}\n");  // вывод результата в консоль
                                _del = Display;
                                if (_del != null) _del(res);
                            }   // конец логического условия
                            else { stat.ErrorsOccured++; Console.WriteLine(errorMessage); } // иначе ошибка
                            break;  // выход из тела оператора switch
                        case (int)operation.Years:   // если было введено "11"
                            Console.WriteLine("Format: [years] [months] [days]");
                            tupleArray = calc.GetArray(); // ввод N с клавиатуры
                            if (tupleArray.Item2)  // если признак ошибки отсутствует
                                                    // вывести в консоль результат вычисления
                            {   // начало логического условия
                                Day days = new Day();    // инициализация дней
                                int[] mas = tupleArray.Item1;   // получили три числа год:месяц:день
                                try    // защита от выхода за границу массива
                                {   // начало тела блока try
                                    period.Years = mas[0];  // выделили годы
                                    period.Months = mas[1]; // выделили месяцы
                                    period.Days = mas[2];   // выделили дни
                                }   // конец тела блока try
                                catch   // отлов исключения
                                {   // начало тела блока catch
                                    Console.WriteLine(errorMessage);    // вывод сообщения об ошибке
                                    break;  // выход из тела оператора switch
                                }   // конец тела блока catch
                                days = period;  // перевод года:месяцы:дни в дни
                                // формирование строки-ответа
                                string res = $"Days: {days.Days}";
                                Memory.List = res;  // добавление в историю записи о вычислении
                                //Console.WriteLine($"{res}\n");  // вывод результата в консоль
                                _del = Display;
                                if (_del != null) _del(res);
                            }   // конец логического условия
                            else { stat.ErrorsOccured++; Console.WriteLine(errorMessage); } // иначе ошибка
                            break;  // выход из тела оператора switch
                        case (int)operation.Geometry:   // сценарий, если было введено "12"
                            // вывод в консоль меню
                            Console.WriteLine("1 - Circle\n2 - Quadrate\n3 - Rectangle\nAny key to Go Up");
                            key = Console.ReadLine();   // чтение с клавиатуры выбора в меню
                            switch (key)    // переключатель условий выбора меню
                            {   // начало тела блока switch
                                case "1":   // выбрана окружность
                                    Console.Write("Enter radius: ");    // запрос входных данных от пользователя
                                    tupleSingle = calc.GetSingleOperator(); // чтение входных данных
                                    if (tupleSingle.Item2)  // проверка на корректность входных данных
                                    {   // начало логического условия
                                        Circle circle = new Circle { Radius = tupleSingle.Item1 };  // инициализация окружности
                                        var result = circle.ToString(); // формирование результата и представление в текстовом виде
                                        Memory.List = result;   // запись результатов в память
                                        //Console.WriteLine(result);  // вывод результатов в консоль
                                        _del = Display;
                                        if (_del != null) _del(result);
                                    }   // конец логического условия
                                    else { stat.ErrorsOccured++; Console.WriteLine(errorMessage); } // сообщение об ошибки
                                    break;  // конец сценария
                                case "2":   // выбран квадрат
                                    Console.Write("Enter edge: ");  // запрос длины стороны
                                    tupleSingle = calc.GetSingleOperator(); // ввод стороны
                                    if (tupleSingle.Item2)  // проверка на корректность
                                    {   // начало if
                                        Quadrate quadrate = new Quadrate { Edge = tupleSingle.Item1 };  // инициализация квадрата
                                        var result = quadrate.ToString();   // подсчет
                                        Memory.List = result;   // запись в память
                                        //Console.WriteLine(result);  // вывод в консоль
                                        _del = Display;
                                        if (_del != null) _del(result);
                                    }   // конец if
                                    else { stat.ErrorsOccured++; Console.WriteLine(errorMessage); } // сообщение об ошибке
                                    break;  // конец сценария
                                case "3":   // выбран параллелограмм
                                    Console.WriteLine("Enter height and width: ");  // запрос длины и ширины
                                    tupleDouble = calc.GetDoubleOperands(); // ввод данных с клавиатуры
                                    if (tupleDouble.Item3)  // проверка на корректность входных данных
                                    {   // начало if
                                        Rectangle rectangle = new Rectangle {   // инициализация фигуры
                                            Height = tupleDouble.Item1, // выделение длины
                                            Width = tupleDouble.Item2   // выделение ширины
                                        };  // конец инициализации
                                        var result = rectangle.ToString();  // формирование результата
                                        Memory.List = result;   // запись в память результата
                                        //Console.WriteLine(result);  // вывод в консоль результата
                                        _del = Display;
                                        if (_del != null) _del(result);
                                    }   // end if
                                    else { stat.ErrorsOccured++; Console.WriteLine(errorMessage); } // сообщение об ошибке
                                    break;  // конец сценария
                                default:    // сценарий по-умолчанию (выход из подменю)
                                    Console.WriteLine("canceled");  // сообщение о выходе из подменю
                                    break;  // конец сценария
                            }   // конец тела блока switch
                            break;  // выход из тела оператора switch
                        default:    // если был введен символ, непредусмотренный консольным меню
                            Console.WriteLine($"The [{key}] key was triggered\n"); // вывод необработанного запроса меню
                            stat.ErrorsOccured++;
                            break;  // выход из тела оператора switch
                    }   // конец тела оператора switch
                }   // конец тела блока else
            }   // конец тела цикла
            
        }   // конец тела метода Main
        
    }   // конец тела класса Program
}   // конец тела объявления пространства имен
