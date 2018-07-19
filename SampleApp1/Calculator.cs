using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp1
{
    public class Calculator    // инициализация класса Calculator
    {   // начало тела класса Calculator
        public Calculator(string name, Memory m)
        {
            this.name = name;
            this.m = m;
        }

        private string name;
        private Memory m = new Memory();

        public string GetName()
        {
            return name;
        }

        public int Add(int a, int b)   // реализация метода сложения двух операндов
        {   // начало тела метода Add
            //m.AddToMemory($"{a} + {b} = {a+b}");    // сохранение решения в "память"
            m.List = $"{a} + {b} = {a + b}";
            return (a + b); // выполнение операции сложения и возврат полученного значения
        }   // конец тела метода Add

        public double Add(double a, double b)   // реализация метода сложения двух операндов
        {   // начало тела метода Add
            //m.AddToMemory($"{a} + {b} = {a+b}");    // сохранение решения в "память"
            m.List = $"{a} + {b} = {a + b}";
            return (a + b); // выполнение операции сложения и возврат полученного значения
        }   // конец тела метода Add

        public int Sub(int a, int b) // реализация метода вычитания одного операнда из другого
        {   // начало тела метода Sub
            //m.AddToMemory($"{a} - {b} = {a - b}");    // сохранение решения в "память"
            m.List = $"{a} - {b} = {a - b}";
            return (a - b); // выполнение операции вычитания и возврат полученного значения
        }   // конец тела метода Sub

        public double Sub(double a, double b) // реализация метода вычитания одного операнда из другого
        {   // начало тела метода Sub
            //m.AddToMemory($"{a} - {b} = {a - b}");    // сохранение решения в "память"
            m.List = $"{a} - {b} = {a - b}";
            return (a - b); // выполнение операции вычитания и возврат полученного значения
        }   // конец тела метода Sub

        public int Mul(int a, int b)   // реализация метода Mul
        {   // начало тела метода Mul
            //m.AddToMemory($"{a} * {b} = {a * b}");    // сохранение решения в "память"
            m.List = $"{a} * {b} = {a * b}";
            return (a * b); // выполнение операции умножения и возврат полученного значения
        }   // конец тела метода Mul

        public double Mul(double a, double b)   // реализация метода Mul
        {   // начало тела метода Mul
            //m.AddToMemory($"{a} * {b} = {a * b}");    // сохранение решения в "память"
            m.List = $"{a} * {b} = {a * b}";
            return (a * b); // выполнение операции умножения и возврат полученного значения
        }   // конец тела метода Mul

        public double Div(double a, double b)   // реализация метода Div
        {   // начало тела метода Div
            //m.AddToMemory($"{a} / {b} = {a / b}");    // сохранение решения в "память"
            m.List = $"{a} / {b} = {a / b}";
            return (a / b); // выполнение операции деления и возврат полученного значения
        }   // конец тела метода Div

        public int And(int a, int b)    // логическое умножение
        {   // начало тела метода
            int result = a & b; // выполнение логической операции
            var binA = Convert.ToString(a, 2);  // перевод десятеричных чисел в двоичные для наглядности
            var binB = Convert.ToString(b, 2);
            var binR = Convert.ToString(result, 2);
            //m.AddToMemory($"{a} & {b} = {a & b}");    // сохранение решения в "память"
            m.List = $"{a} & {b} = {a & b}";
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
            //m.AddToMemory($"{a} | {b} = {a | b}");    // сохранение решения в "память"
            m.List = $"{a} | {b} = {a | b}";
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
            //m.AddToMemory($"{a} ^ {b} = {a ^ b}");    // сохранение решения в "память"
            m.List = $"{a} ^ {b} = {a ^ b}";
            Console.WriteLine($"{binA} ^ {binB} = {binR}"); // вывод в консоль входных и выходных данных
                                                            // в двоичном виде для наглядности
            return result;  // возврат полученного результата
        }   // конец тела метода

        public int Factorial(int n, Boolean flag = false) // вычисление факториала
            /* необязательный параметр flag нужен для того, чтобы в консоль выводился только 
             * результат из самого верхнего уровня рекурсии, но не писалось при каждом ее вызове
             */
        {   // начало тела функции
            // рекурсивное вычисление факториала и граничное условие
            int result = (n == 0) ? 1 : n * Factorial(n - 1);
            //if (flag) m.AddToMemory($"Factorial({n}) = {result}");    // сохранение решения в "память"
            if (flag) m.List = ($"Factorial({n}) = {result}");
            return result;  // возврат результата вычисления
        }   // конец тела функции

        public int SumArray(params int[] array)    // функция суммирования элементов массива
        {   // начало тела функции
            int result = 0; // инициализация переменной "результат" и определение начального значения
            foreach (int n in array)    // цикль для работы с массивами
            {   // начало тела цикла
                result += n;    // суммирование элементов массива
            }   // конец тела цикла
                //m.AddToMemory($"Sum of array = {result}");    // сохранение решения в "память"
            m.List = $"Sum of array = {result}";
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

}
