using System;
using System.Collections.Generic;
using System.Text;

namespace OperationOverloadInheritance
{

    // Определение подкласса Кот
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} мяукает");
        }

        public override void Eat(Food food)
        {
            if (food is Fish)
            {
                Console.WriteLine($"{Name} ест {food.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} не ест {food.Name}");
            }
        }
    }
}