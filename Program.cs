using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Animals.Models;

namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Cat C1 = new Cat("bushuuy", 2, 'X', 60, 122.5f, 30, false);
           // C1.Sleep();
            //og D1 = new Dog("Bob", 5, 'Y', 40, 98.3f, 50);
            //D1.Sleep();
            Animal D2 = new Dog("Bob", 5, 'Y', 40, 98.3f, 50);  //D2.Sleep();
            Animal[] anims = new Animal[2]    
            {
                C1, D2
            };
            Console.ReadKey();  
           //anims[0].Eat();
           // List<Animal> animals = new List<Animal>();
            //animals.Add(C1);   animals.Add( D2);  animals.Insert(0, C1);
            //animals.ForEach(p => Console.WriteLine(p.Age ));
            PetShop p = new PetShop ();
            p.AddAnim(C1);
            


        }
    }
}