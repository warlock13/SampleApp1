namespace SampleApp1    // область пространство имен
{   // начало области

    interface IPet  // интерфейс 
    {   // начало интерфейса
        string Eats();  // что ест питомец
        string Feed(string food);   // кормнение питомца 
        string Moves(); // способ перемещения питомца
        string Lives(); // где живет питомец
    }   // конец интерфейса

    public abstract class Pet : IPet    // абстратный класс питомец
    {   // начало класса
        public string Name { get; set; }    // св-во имя
        public abstract string Eats();  // абстрактный метод
        public string Feed(string food) // реализованный метод
        {   // начало метода
            return this.Eats().Equals(food) ?           //возвращение резлуьтата 
                $"{this.Name} ate some {this.Eats()}" : // выполнения тернарного оператора
                $"{this.Name} did not eat {food}";
        }   // конец метода
        public abstract string Lives(); // абстрактный метод "живет"
        public abstract string Moves(); // абстрактный метода "двигается"
    }   // конец класса

    public class Cat : Pet  // реализация класса Кот
    {   // начало класса
        public override string Eats()   // перегрузка метода
        {   // наачало метода
            return "fish";  // возвращение строки
        }   // конец метода
        public override string Lives()  // перегрузка метода
        {   // начлао метода
            return "box";   // возвращение строки
        }   // конец метода
        public override string Moves()  // перегрузка метода
        {   // начало метода
            return "walk";  // возвращение строки
        }   // конец метода
    }   // конец класса

    public class Mouse : Pet  // реализация класса Кот
    {   // начало класса
        public override string Eats()   // перегрузка метода
        {   // наачало метода
            return "cheese";  // возвращение строки
        }   // конец метода
        public override string Lives()  // перегрузка метода
        {   // начлао метода
            return "cell";   // возвращение строки
        }   // конец метода
        public override string Moves()  // перегрузка метода
        {   // начало метода
            return "run";  // возвращение строки
        }   // конец метода
    }   // конец класса

    public class Bird : Pet  // реализация класса Кот
    {   // начало класса
        public override string Eats()   // перегрузка метода
        {   // наачало метода
            return "seeds";  // возвращение строки
        }   // конец метода
        public override string Lives()  // перегрузка метода
        {   // начлао метода
            return "cage";   // возвращение строки
        }   // конец метода
        public override string Moves()  // перегрузка метода
        {   // начало метода
            return "fly";  // возвращение строки
        }   // конец метода
    }   // конец класса
    
}   // конец области
