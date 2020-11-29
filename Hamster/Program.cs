using System;

namespace Hamster
{
    class Program
    {
        class Hamster
        {
            string name = "Pew";
            double age = 0;
            double weight = 0.1;
            double lifespan = 0;
            private string v;

            public Hamster(string v)
            {
                this.v = v;
            }

            public Hamster(string _name, double _age, double _weight, double _lifespan)
            {
                name = _name;
                age = _age;
                weight = _weight;
                lifespan = _lifespan;                
                Console.WriteLine($"The pet {name} has been created.");
            }
            public double Age
            {
                get { return age; }
            }
            public double Weight
            {
                get { return weight; }
            }
            public double Lifespan
            {
                get { return lifespan; }
            }
            public void ShowPetData()
            {
                Console.WriteLine($"Name: {name}; age: {age}; lifespan: {lifespan}; weight: {weight}.");
            }
            public void Eat()
            {
                Console.WriteLine("Nom-Nom");
                weight += 0.2;
            }
            public void Exercise()
            {
              weight -= 0.2;
            }
        }
        static void Main(string[] args)
        {
            Hamster newPet = new Hamster("Pew");
            newPet.ShowPetData();
        }
    }
}
