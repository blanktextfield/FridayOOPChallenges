using System;

namespace FridayOOPChallenges
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double hunger;
            public Cat(string _name, string _color)
            {
             name = _name;
             color = _color;
             hunger = 0;
             Console.WriteLine($"The cat {name} has been created.");
            }
            public double Hunger
            {
             get { return hunger; }
            }
            public void Sleep()
            {
             Console.WriteLine("ZZZZ-ZZZZ");
             hunger += 0.2;
            }
            public void Meow()
            {
             Console.WriteLine("Meow-Meow");
            }
            public void Rename(string newName)
            {
             name = newName;
            }
            public void ShowCatData()
            {
             Console.WriteLine($"Name: {name}; color: {color}; hunger: {hunger};");
            }            
        }
        static void Main(string[] args)
        {
            Cat newCat = new Cat("Paws", "red");
            Console.WriteLine($"The level of hunger: {newCat.Hunger}");
            while (newCat.Hunger != 1)
            {
             newCat.Sleep();               
            }
            newCat.Meow();
            Console.WriteLine("Rename the cat");
            string newCatName = Console.ReadLine();
            newCat.Rename(newCatName);
            newCat.ShowCatData();
        }

    }
}
