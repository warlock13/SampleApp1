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

    class Calculator    // инициализация класса Calculator
    {   // начало тела класса Calculator
        public int Add(int a, int b)   // реализация метода сложения двух операндов
        {   // начало тела метода Add
            return (a + b); // выполнение операции сложения и возврат полученного значения
        }   // конец тела метода Add

        public int Sub(int a, int b) // реализация метода вычитания одного операнда из другого
        {   // начало тела метода Sub
            return (a - b); // выполнение операции вычитания и возврат полученного значения
        }   // конец тела метода Sub

        public int Mul(int a, int b)   // реализация метода Mul
        {   // начало тела метода Mul
            return (a * b); // выполнение операции умножения и возврат полученного значения
        }   // конец тела метода Mul

        public double Div(double a, double b)   // реализация метода Div
        {   // начало тела метода Div
            return (a / b); // выполнение операции деления и возврат полученного значения
        }   // конец тела метода Div

        public int And(int a, int b)    // логическое умножение
        {   // начало тела метода
            int result = a & b; // выполнение логической операции
            var binA = Convert.ToString(a, 2);  // перевод десятеричных чисел в двоичные для наглядности
            var binB = Convert.ToString(b, 2);
            var binR = Convert.ToString(result, 2);
            Console.WriteLine($"{binA} & {binB} = {binR}"); // вывод в консоль входных и выходных данных
                                                            // в двоичном виде для наглядности
            return result;  // возврат полученного результата
        }   // конец тела метода

        public int Or(int a, int b)    // логическое сложение
        {   // начало тела метода
            int result = a | b; // выполнение логической операции
            var binA = Convert.ToString(a, 2);  // перевод десятеричных чисел в двоичные для наглядности
            var binB = Convert.ToString(b, 2);
            var binR = Convert.ToString(result, 2);
            Console.WriteLine($"{binA} | {binB} = {binR}"); // вывод в консоль входных и выходных данных
                                                            // в двоичном виде для наглядности
            return result;  // возврат полученного результата
        }   // конец тела метода

        public int Xor(int a, int b)    // сложение по модулю два
        {   // начало тела метода
            int result = a ^ b; // выполнение логической операции
            var binA = Convert.ToString(a, 2);  // перевод десятеричных чисел в двоичные для наглядности
            var binB = Convert.ToString(b, 2);
            var binR = Convert.ToString(result, 2);
            Console.WriteLine($"{binA} ^ {binB} = {binR}"); // вывод в консоль входных и выходных данных
                                                            // в двоичном виде для наглядности
            return result;  // возврат полученного результата
        }   // конец тела метода

        public int Factorial(int n) // вычисление факториала
        {   // начало тела функции
            // рекурсивное вычисление факториала и граничное условие
            int result = (n == 0) ? 1 : n * Factorial(n - 1);
            return result;  // возврат результата вычисления
        }   // конец тела функции

        public int SumArray(params int [] array)    // функция суммирования элементов массива
        {   // начало тела функции
            int result = 0; // инициализация переменной "результат" и определение начального значения
            foreach (int n in array)    // цикль для работы с массивами
            {   // начало тела цикла
                result += n;    // суммирование элементов массива
            }   // конец тела цикла
            return result;  // возврат полученной суммы
        }   // конец тела функции

        public (int, int, Boolean) GetIntOperands() // метод для ввода с клавиатуры операндов типа int
        {   // начало тела метода
            int a1 = 0; // инициализация переменный и задание начальных значений
            int b1 = 0;
            Boolean flag;   // признак корректности входных данных
            Console.Write("a = ");  // вывод в консоль названия первого операнда
            var a = Console.ReadLine(); // ввод значения первого операнда с клавиатуры
            Console.Write("b = ");  // вывод в консоль названия второго операнда
            var b = Console.ReadLine(); // ввод значения второго операнда с клавиатуры
            try    // блок защиты кода, который может выбросить исключение
            {   // начало тела блока try
                a1 = int.Parse(a);  // попытка преобразовать string -> int
                b1 = int.Parse(b);  // попытка преобразовать string -> int
                flag = true;    // данные корректны
                return (a1, b1, flag); // возврат считанных чисел + признака корректности
            }   // конец тела блока try
            catch (FormatException err) // обработка исключения "формат аргумента недопустим"
            {   // начало тела блока catch
                //Console.Write("Incorrect input data\n"); // возврат признака начилия ошибки во входных данных
                flag = false;   // признал наличия ошибки во входных данных
                return (a1, b1, flag);  // возврат дефолтных значений и признака наличия ошибки
            }   // конец тела блока catch
        }   // конец тела метода

        public (int, Boolean) GetSingleOperator()   // метод для ввода с клавиатуры операнда
        {   // начало тела метода
            int n1 = 0; // инциализация и определение дефолтного значения
            Boolean flag;   // инициализация флага 
            Console.Write("n = ");  // вывод в консоль названия первого операнда
            var n = Console.ReadLine(); // ввод значения второго операнда с клавиатуры
            try    // блок защиты кода, который может выбросить исключение
            {   // начало тела блока try
                n1 = int.Parse(n);  // попытка преобразовать string -> int
                flag = true;    // признак корректности
                return (n1, flag);  // возврат int + признака корректности
            }   // конец тела блока try
            catch (FormatException err) // обработка исключения "формат аргумента недопустим"
            {   // начало тела блока catch
                //Console.Write("Incorrect input data\n"); // возврат признака начилия ошибки во входных данных
                flag = false;   // празнак некорректности входных данных
                return (n1, flag);  // возврат дефолтного значения + признака некорректности
            }   // конец тела блока catch
        }   // конец тела метода

        public (double, double, Boolean) GetDoubleOperands()    // аналогично для ввода double-значений
        {   // начало тела метода
            double a1 = 0;  // инициализация и определение дефолтных значений
            double b1 = 0;
            Boolean flag;   // флаг наличия ошибки
            Console.Write("a = ");  // вывод в консоль названия первого операнда
            var a = Console.ReadLine(); // ввод значения первого операнда с клавиатуры
            Console.Write("b = ");  // вывод в консоль названия второго операнда
            var b = Console.ReadLine(); // ввод значения второго операнда с клавиатуры
            try    // блок защиты кода, который может выбросить исключение
            {   // начало тела блока try
                a1 = double.Parse(a);  // попытка преобразовать string -> int
                b1 = double.Parse(b);  // попытка преобразовать string -> int
                flag = true;    // данные корректные
                return (a1, b1, flag);  // возврат кортежа
            }   // конец тела блока try
            catch (FormatException err) // обработка исключения "формат аргумента недопустим"
            {   // начало тела блока catch
                //Console.Write("Incorrect input data\n"); // возврат признака начилия ошибки во входных данных
                flag = false;   // данные некорректные
                return (a1, b1, flag);  // возврат кортежа
            }   // конец тела блока catch
        }   // конец тела метода

        public (int[], Boolean) GetArray()  // метод для ввода массива с клавиатуры
        {   // начало тела метода
            // подсказка как ввести массив в консоль
            Console.WriteLine("Enter int separated by spaces\n(Example: '0 1 2 3 4 5')");
            Boolean flag = true; // инициализация и задание начального значения флага
            string line = Console.ReadLine();   // ввод строки чисел с клавиатуры
            var numbers = line.Split(' ');  // разбиение строки чисел на массив (пробел - разделитель)
            int[] array = new int[numbers.Length]; // инициализация int-массива для хранения чисел
            for (int i = 0; i < numbers.Length; i++) // проход по всем элементам разбитой строки
            {   // начало тела цикла
                try { array[i] = int.Parse(numbers[i]); } // попытка преобразовать string -> int
                                                          // и запись в int-массив  
                catch { flag = false; break; } // отлов возможного исключения (введено не int-значение)
                // формирование признака некорректности входной строки и выход из тела цикла
            }   // конец тела цикла
            return (array, flag);   // возврат 
        }   // конец тела метода

    }   // конец тела класса Calculator

    class Program   // инициализация главного класса
    {   // начало тела класса Program
        static void Main(string[] args) // реализация запускающего метода Main
        {   // начало тела метода Main
            var menu = "Console menu:" +    // инициализация string-переменной
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
                "\nQ - Exit\n";             
            Console.WriteLine(menu);    // вывод в консоль текстового меню
            Calculator calc = new Calculator(); // инициализация экземпляра класса Calculator
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
                            else Console.WriteLine("Incorrect input data");
                            break;  // выход из тела оператора switch
                        case (int)operation.Sub:   // сценарий, если было введено "2"
                            tuple = calc.GetIntOperands();
                            if (tuple.Item3)
                                Console.WriteLine("Ans = " + calc.Sub(tuple.Item1, tuple.Item2) + "\n");
                            else Console.WriteLine("Incorrect input data");
                            break;  // выход из тела оператора switch
                        case (int)operation.Mul:   // сценарий, если было введено "3"
                            tuple = calc.GetIntOperands();  // инициализация кортежа
                            if (tuple.Item3)    // если признак ошибки отсутствует
                                // вывести в консоль результат вычисления
                                Console.WriteLine("Ans = " + calc.Mul(tuple.Item1, tuple.Item2) + "\n");
                            else Console.WriteLine("Incorrect input data"); // иначе сообщение об ошибке
                            break;  // выход из тела оператора switch
                        case (int)operation.Div:   // сценарий, если было введено "4"
                            var tupleDouble = calc.GetDoubleOperands(); // инициализация котрежа
                            if (tupleDouble.Item3)  // если признак ошибки отсутствует
                                // вывести в консоль результат вычисления
                                Console.WriteLine("Ans = " + calc.Div(tupleDouble.Item1, tupleDouble.Item2) + "\n");
                            else Console.WriteLine("Incorrect input data"); // иначе сообщение об ошибке
                            break;  // выход из тела оператора 
                        case (int)operation.Or: // если было введено "6"
                            tuple = calc.GetIntOperands(); // инициализация кортежа
                            if (tuple.Item3)  // если признак ошибки отсутствует
                                // вывести в консоль результат вычисления
                                Console.WriteLine("Ans = " + calc.Or(tuple.Item1, tuple.Item2) + "\n");
                            else Console.WriteLine("Incorrect input data");
                            break;  // выход из тела оператора switch
                        case (int)operation.And:    // если было введено "5"
                            tuple = calc.GetIntOperands();  // ввод с клавиатуры int-операторов
                            if (tuple.Item3)  // если признак ошибки отсутствует
                                // вывести в консоль результат вычисления
                                Console.WriteLine("Ans = " + calc.And(tuple.Item1, tuple.Item2) + "\n");
                            else Console.WriteLine("Incorrect input data"); // иначе сообщение об ошибке
                            break;  // выход из тела оператора switch
                        case (int)operation.Xor:    // если было введено "7"
                            tuple = calc.GetIntOperands(); // кортеж
                            if (tuple.Item3)  // если признак ошибки отсутствует
                                // вывести в консоль результат вычисления
                                Console.WriteLine("Ans = " + calc.Xor(tuple.Item1, tuple.Item2) + "\n");
                            else Console.WriteLine("Incorrect input data"); // сообщение об ошибке
                            break;  // выход из тела оператора switch
                        case (int)operation.Factorial:  // если было введено "8"
                            var tupleSingle = calc.GetSingleOperator(); // ввод N с клавиатуры
                            if (tupleSingle.Item2)  // если признак ошибки отсутствует
                                // вывести в консоль результат вычисления
                                Console.WriteLine($"Factorial({tupleSingle.Item1}) = "
                                    + calc.Factorial(tupleSingle.Item1) + "\n");
                            else Console.WriteLine("Incorrect input data"); // иначе ошибка
                            break;  // выход из тела оператора switch
                        case (int)operation.SumArray:   // если было введено "9"
                            var tupleArray = calc.GetArray();   // ввод массива с клавиатуры
                            if (tupleArray.Item2)  // если признак ошибки отсутствует
                                // вывести в консоль результат вычисления
                                Console.WriteLine("Sum of array = "
                                    + calc.SumArray(tupleArray.Item1) + "\n");
                            else Console.WriteLine("Incorrect input data"); // иначе ошибка
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
