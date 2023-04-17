using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    internal class Fish : Animal 
    {
        public string BreedOfFish { get; set; }
        public Fish(string nickname, short age, char gender, int energy, float price, float mealquantity, string breed) :
           base(nickname, age, gender, energy, price, mealquantity)
        {
            BreedOfFish = breed;
        }
        public override void Eat()
        {
            if (Energy >= 100) { Console.WriteLine("Fish is not hungry "); return; }
            Console.WriteLine("Fish eating ... ");
            Age *= 1.1f;
            Price++;
            MealQuantity *= 1.5f;
            Energy += 20;
        }
        public override void Sleep()
        {
            Console.WriteLine("Fish go to sleep ");
            Energy += 20;
            System.Threading.Thread.Sleep(3000);
        }
        public override void Play()
        {
            if (Energy > 0)
            {
                Console.WriteLine("Fish is playing ))");
                Energy--;
            }
            else { Console.WriteLine("Fish must sleep or eat something "); }
        }
    }
}
