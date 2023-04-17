using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    internal class Cat : Animal 
    {
        bool IsPredatory { get; set; }
        public Cat(string nickname, short age, char gender, int energy, float price, float mealquantity,  bool ispredatery) :
           base(nickname, age, gender, energy, price, mealquantity)
        {
            this.IsPredatory = ispredatery;
        }

        public override void Eat()
        {
            if (Energy >= 100) { Console.WriteLine("Cat is not hungry "); return; }
            Console.WriteLine("Cat eating ... ");
            Age *= 1.1f;
            Price++;
            MealQuantity *= 1.5f;
            Energy += 20;
        }
        public override void Sleep()
        {
            Console.WriteLine("Cat go to sleep ");
            Energy += 20;
            System.Threading.Thread.Sleep(3000);
        }
        public override void Play()
        {
            if (Energy > 0)
            {
                Console.WriteLine("Cat is playing ))");
                Energy--;
            }
            else { Console.WriteLine("Cat must sleep or eat something "); }
        }

    }
}
