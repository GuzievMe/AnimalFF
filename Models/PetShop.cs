using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    public  class PetShop 
    {
        /////ArrayList Wt = new ArrayList(); ////
       

        List<Animal> animals;
        public PetShop() { animals = new List<Animal>(); }
        
        
        public int A { get; set; }
        public void B() { Console.WriteLine("maaa"); }
        internal  void AddAnim(Animal  anim)
        {
            animals.Add(anim);
            Console.WriteLine(anim.Age);
         
        }
        internal void AddAnimss(Animal[] anim)
        {
            animals.AddRange(anim);
        }

        public void RemoveByNickName(string nickname)
        {
            foreach (var del in animals)
            {
              
                if (del.Nickname == nickname)
                {
                    animals.Remove(del);
                    return;
                }
                // }
            }
            Console.WriteLine($"Animal not found : {nickname}");
        }

        public float TotalPriceOfCats()
        {
            float totalPrice = 0;
            foreach (var cat in animals)
            {
                if (cat is Cat)
                {
                    totalPrice += cat.Price;
                }
            }
            return totalPrice;
        }
        public float TotalPriceOfDogs()
        {
            float totalPrice = 0;
            foreach (var dog in animals)
            {
                if (dog is Dog)
                {
                    totalPrice += dog.Price;
                }
            }
            return totalPrice;
        }
        public float TotalPriceOfBird()
        {
            float totalPrice = 0;
            foreach (var bird in animals)
            {
                if (bird is Bird)
                {
                    totalPrice += bird.Price;
                }
            }
            return totalPrice;
        }
        public float TotalPriceOfFish()
        {
            float totalPrice = 0;
            foreach (var fish in animals)
            {
                if (fish is Fish)
                {
                    totalPrice += fish.Price;
                }
            }
            return totalPrice;
        }


        public float GetTotalMealQuantity()
        {
            float totalMealQuantity = 0;

            foreach (var junul in animals)
            {
                totalMealQuantity += junul.MealQuantity;
            }
            return totalMealQuantity;
        }
    }
}
