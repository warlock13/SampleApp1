namespace SampleApp1    // описание пространства имен
{   // начало пространства имен
    //enum Month
    //{
    //    January = 31,
    //    February = 28,
    //    March = 31,
    //    April = 30,
    //    May = 31,
    //    June = 30,
    //    July = 31,
    //    August = 31,
    //    September = 30,
    //    October = 31,
    //    November = 30,
    //    December = 31
    //}

    public class Period // описание класса
    {   // начало класса
        public int Days { get; set; }   // свойства для дней
        public int Months { get; set; } // св-ва для месяцев
        public int Years { get; set; }  // св-ва для лет

        public static implicit operator Day(Period p)   // перегрузка преобразования типов
        {   // начало перегрузки
            int d = p.Days; // выделение дней
            int m = p.Months * 30;  // подсчет дней в месяце
            int y = p.Years * 365;  // подсчет дней в году
            return new Day { Days = d + m + y };    // суммирование рассчитаных значений
        }   // конец перегрузки
            
        public static implicit operator Period(Day days)    // перегрузка преобразования типов
        {   // начало перегрузки
            int y = days / 365; // выделение лет
            days %= 365;    // вычисление остатка от неполного года
            int m = days / 30;  // выделение месяцев
            days %= 30; // вычисление остатка от неполного месяца
            int d = days;   // выделение остатка дней
            return new Period { Days = d, Months = m, Years = y };  // возврат дней, месяцев, лет
        }   // конец перегрузки

    }   // конец класса

    public class Day    // описание класса
    {   // начало класса
        public int Days { get; set; }   // св-ва для дней

        public static implicit operator int(Day d)  // перегрузка преобразования типов
        {   // начало перегрузки
            return d.Days;  // возвращение int числа дней
        }   // конец перегрузки

        public static implicit operator Day(int n)  // перегрузка преобразования типов
        {   // начало перегрузки
            return new Day { Days = n };    // возвращение дней типа Day
        }   // конец перегрузки
    }   // конец класса
}   // начало пространства имен
