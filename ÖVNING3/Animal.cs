namespace ÖVNING3
{
    internal abstract class Animal
    {
        public string Namn { get; set; }
        public double Vikt { get; set; }
        public int Age { get; set; }
        public Animal(string namn, double vikt, int age)
        {
            Namn = namn;
            Vikt = vikt;
            Age = age;
        }
        public abstract string DoSound();
        public virtual string Stats()
        {
            return $"{Namn} animal is {Age} and grow {Vikt}";
        }


    }
    internal class Horse : Animal, IPerson
    {
        public Horse(string namn, double vikt, int age, string eat) : base(namn, vikt, age)
        {
            Eat = eat;
        }

        public string Eat { get; set; }
        public override string DoSound()
        {
            return $"Neigh";
        }
        public override string Stats()
        {
            return base.Stats() + $"Food it eats: {Eat}";
        }

        public void Talk()
        {
            Console.WriteLine("I'm a Centaur!"); ;
        }
    }
    internal class Dog : Animal
    {
        public Dog(string namn, double vikt, int age) : base(namn, vikt, age)
        {
        }

        public override string DoSound()
        {
            return $"bark";

        }
        public override string Stats()
        {
            return $"Dog animal is {Age} and grow {Vikt}";
        }
    }
    internal class Hedgehog : Animal
    {
        public Hedgehog(string namn, double vikt, int age) : base(namn, vikt, age)
        {
        }

        public int NrOfSpikes { get; set; }
        public override string DoSound()
        {
            return $"hedgehogsound";

        }
        public override string Stats()
        {
            return $"{Namn} animal is {Age} and grow {Vikt} and number of spikes are {NrOfSpikes}";
        }
    }
    internal class Worm : Animal
    {
        public Worm(string namn, double vikt, int age) : base(namn, vikt, age)
        {
        }

        public override string DoSound()
        {
            return $"wornsound";

        }

    }
    class Bird : Animal
    {
        public Bird(string namn, double vikt, int age) : base(namn, vikt, age)
        {
        }

        public double WingSpan { get; set; }
        public override string DoSound()
        {
            return $"tweet";

        }


    }
    internal class Wolf : Animal
    {
        public Wolf(string namn, double vikt, int age) : base(namn, vikt, age)
        {
        }

        public bool IsPoisonous { get; set; }
        public override string DoSound()
        {
            return $"wolfsound";

        }

    }
    internal class Pelican : Bird
    {
        public Pelican(string namn, double vikt, int age) : base(namn, vikt, age)
        {
        }
    }
    internal class Flamingo : Bird
    {
        public Flamingo(string namn, double vikt, int age) : base(namn, vikt, age)
        {
        }
    }

    internal class Swan : Bird
    {
        public Swan(string namn, double vikt, int age) : base(namn, vikt, age)
        {
        }
    }

}
