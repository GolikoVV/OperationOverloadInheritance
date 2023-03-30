using System;
using System.Collections.Generic;
using System.Text;

namespace OperationOverloadInheritance
{

    // Определение подкласса Собака
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} гавкает");
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
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
