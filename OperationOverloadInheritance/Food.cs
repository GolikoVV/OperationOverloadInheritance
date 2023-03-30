using System;
using System.Collections.Generic;
using System.Text;

namespace OperationOverloadInheritance
{
    // Определение класса Еда
    class Food
    {
        public string Name { get; set; }
    }

    // Определение подкласса Рыба
    class Fish : Food
    {
        public Fish()
        {
            Name = "рыбу";
        }
    }
}
/*
 Класс "Food" определяет общие свойства для всех видов еды, а его подклассы "Fish", 
"Meat" и "Grass" определяют конкретные виды еды.
 */