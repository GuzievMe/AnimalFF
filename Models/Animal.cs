using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    internal abstract class Animal
    {
        public Animal() { }
        public Animal(string nickname, short age, char gender, int energy, float price, float mealquantity)
        {
            Nickname = nickname;
            Age = age; Gender = gender; Energy = energy; Price = price; MealQuantity = mealquantity;
        }
        /////////////////Properties
        public string Nickname { get; set; }
        public double Age { get; set; }
        public char Gender { get; set; }
        public int Energy { get; set; }
        public float Price { get; set; }
        public float MealQuantity { get; set; }
        public abstract void Eat();

        public abstract void Sleep();

        public abstract void Play();
    }
}
