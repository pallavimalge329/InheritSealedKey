using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LateBinding
{

    class Animal
    {
        public virtual void FoodHabits()
        {
            Console.WriteLine("Animals have different food  habits");
        }
        public virtual void display()
        {
            Console.WriteLine("Calling from animal class");
        }
    }

    class Carnivorous : Animal
    {
        sealed override public void FoodHabits()
        {
            Console.WriteLine("I eat only meat");
        }

        public override void display()
        {
            Console.WriteLine("calling from carnivorous class");
        }
    }

    class Carnivorouschild : Carnivorous
    {
        public override void display()
        {
            Console.WriteLine("calling from child of carnivorous");
        }
    }

    class Implement
    {
        public void callFunction(Animal cr)
        {
            cr.FoodHabits();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance Demo!");
            Implement im = new Implement();
            Carnivorous cr = new Carnivorous();
            // calling an object at runtime 
            im.callFunction(cr);
            Console.ReadKey();
        }
    }

}
