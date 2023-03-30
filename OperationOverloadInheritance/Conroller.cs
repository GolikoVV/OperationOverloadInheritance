using System;
using System.Collections.Generic;
using System.Text;

namespace OperationOverloadInheritance
{
    // Определение класса Контроллер
    class Controller
    {
        public void Feed(Animal animal, Food food)
        {
            animal.Eat(food);
        }
    }
}
/*
 Класс "Controller" содержит метод "Feed", 
который принимает объекты "Animal" и "Food" и вызывает метод "Eat" 
для животного с переданным объектом еды.
 */