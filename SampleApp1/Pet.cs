using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp1
{

    interface IPet
    {
        string Eats();
        string Feed(string food);
        string Moves();
        string Lives();
    }

    public abstract class Pet : IPet
    {
        public string Name { get; set; }
        public abstract string Eats();
        public string Feed(string food)
        {
            return this.Eats().Equals(food) ?
                $"{this.Name} ate some {this.Eats()}" :
                $"{this.Name} did not eat {food}";
        }
        public abstract string Lives();
        public abstract string Moves();
    }

    public class Cat : Pet
    {
        public override string Eats()
        {
            return "fish";
        }
        public override string Lives()
        {
            return "box";
        }
        public override string Moves()
        {
            return "walk";
        }
    }

    public class Mouse : Pet
    {
        public override string Eats()
        {
            return "cheese";
        }
        public override string Lives()
        {
            return "cell";
        }
        public override string Moves()
        {
            return "run";
        }
    }

    public class Bird : Pet
    {
        public override string Eats()
        {
            return "seeds";
        }
        public override string Lives()
        {
            return "cage";
        }
        public override string Moves()
        {
            return "fly";
        }
    }

    class Launcer
    {
        public static void Main(string[] args)
        {
            Cat cat = new Cat { Name = "Markiz" };
            Mouse mouse = new Mouse { Name = "Stuard" };
            Bird bird = new Bird { Name = "Kiryusha" };

            Console.WriteLine(cat.Feed("fish"));
            Console.WriteLine(mouse.Feed("cheese"));
            Console.WriteLine(bird.Feed("seeds"));
            Console.WriteLine(cat.Feed("seeds"));

            Console.WriteLine($"{cat.Name} likes to {cat.Moves()}");
            Console.WriteLine($"{mouse.Name} likes to {mouse.Moves()}");
            Console.WriteLine($"{bird.Name} likes to {bird.Moves()}");




            Console.ReadKey();
        }
    }


    
}
