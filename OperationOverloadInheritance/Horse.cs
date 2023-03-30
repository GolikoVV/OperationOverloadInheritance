using System;
using System.Collections.Generic;
using System.Text;

namespace OperationOverloadInheritance
{
    // Определение подкласса Лошадь
    class Horse : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} ржет");
        }

        public override void Eat(Food food)
        {
            if (food is Grass)
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
