using System;

namespace OperationOverloadInheritance
{
    // Пример использования классов
    class Program
    {
        static void Main()
        {
            var cat = new Cat { Name = "Эндрю" };
            var dog = new Dog { Name = "Браун" };
            var horse = new Horse { Name = "Джон" };
            var fish = new Fish();
            var meat = new Meat();
            var grass = new Grass();

            cat.MakeSound(); // "Эндрю мяукает"
            dog.MakeSound(); // "Браун гавкает"
            horse.MakeSound(); // "Джон рычит
            cat.Eat(fish); // "Эндрю ест рыбу"
            dog.Eat(meat); // "Браун ест мясо"
            horse.Eat(grass); // "Джон ест траву"

            var controller = new Controller();
            controller.Feed(cat, meat); // "Эндрю не ест мясо"
            controller.Feed(dog, fish); // "Браун не ест рыбу"
            controller.Feed(horse, grass); // "Джон ест траву"

            cat.Sleep(); // "Эндрю спит"
            dog.Sleep(); // "Браун спит"
            horse.Sleep(); // "Джон спит"
        }
    }
    }
/*
 В основной функции "Main" создаются объекты животных и еды, 
которые затем используются для вызова методов классов.
 */