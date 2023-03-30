using System;
using System.Collections.Generic;
using System.Text;

namespace OperationOverloadInheritance
{
    using System;

    // Определение класса Животное
    class Animal
    {
        public string Name { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} издает звук");
        }

        public virtual void Eat(Food food)
        {
            Console.WriteLine($"{Name} кушает {food.Name}");
        }

        public virtual void Sleep()
        {
            Console.WriteLine($"{Name} спит");
        }
    }
}
/*В данном примере класс "Animal" определяет общие методы "MakeSound",
"Eat" и "Sleep", которые могут быть переопределены в подклассах "Cat", "Dog" и "Horse". */