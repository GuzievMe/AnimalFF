using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    internal class Dog : Animal
    {
        public Dog(string nickname, short age, char gender, int energy, float price, float mealquantity) :
            base(nickname, age, gender, energy, price, mealquantity)
        {

        }
        public override void Eat()
        {
            if (Energy >= 100) { Console.WriteLine("Dog is not hungry "); return; }
            Console.WriteLine("Dog eating ... ");
            Age *= 1.1f;
            Price++;
            MealQuantity *= 1.5f;
            Energy += 20;
        }
        public override void Sleep()
        {
            Console.WriteLine("Dog go to sleep ");
            Energy += 20;
            System.Threading.Thread.Sleep(3000);
        }
        public override void Play()
        {
            if (Energy > 0)
            {
                Console.WriteLine("Dog is playing ))");
                Energy--;
            }
            else { Console.WriteLine("Dog must sleep or eat something "); }
        }

    }
}
