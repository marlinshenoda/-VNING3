using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖVNING3
{
    internal abstract class Animal
    {
        public string Namn { get; set; }
        public double Vikt { get; set; }
        public int Ålder { get; set; }
        public abstract string DoSound();
        public Animal()
        {

        }
        public virtual string Stats()
        {
            return $"{Namn} animal is {Ålder} and grow {Vikt}";
        }


    }
    internal class Horse: Animal
    {
        public string eat { get; set;}
        public override string DoSound()
        {
            return $"Neigh";
        }
        public override string Stats()
        {
            return $"{Namn} animal is {Ålder} and grow {Vikt}";
        }
    }
    internal class Dog: Animal
    {
         
        public override string DoSound()
        {
            return $"bark";

        }
        public override string Stats()
        {
            return $"Dog animal is {Ålder} and grow {Vikt}";
        }
    } 
    internal class Hedgehog: Animal
    {
        public int NrOfSpikes { get; set; } 
        public override string DoSound()
        {
            return $"hedgehogsound";

        }
        public override string Stats()
        {
            return $"{Namn} animal is {Ålder} and grow {Vikt} and number of spikes are {NrOfSpikes}";
        }
    } 
    internal class Worm: Animal
    {
        public override string DoSound()
        {
            return $"wornsound";

        }
        public override string Stats()
        {
            return $"{Namn} animal is {Ålder} and grow {Vikt} his sound is {DoSound()}";
        }
    }
     class Bird: Animal
    {
        public double WingSpan { get; set; }    
        public override string DoSound()
        {
            return $"tweet";

        }
        public override string Stats()
        {
            return $"Bird animal is {Ålder} and grow {Vikt} his sound is {DoSound()}and wing span is{WingSpan}";
        }

    }
    internal class Wolf: Animal
    {
       public bool IsPoisonous { get; set; }    
        public override string DoSound()
        {
            return $"wolfsound";

        }
        public override string Stats()
        {
            return $"Wolf animal is {Ålder} and grow {Vikt} his sound is {DoSound()} and is poisonous{IsPoisonous}";
        }
    } 
    internal class Pelican: Bird
    {
        public override string Stats()
        {
            return $"{Namn} animal is {Ålder} and grow {Vikt}";
        }
    } 
    internal class Flamingo: Bird
    {
        public override string Stats()
        {
            return $"Flamingo animal is {Ålder} and grow {Vikt} ";
        }
    }  

    internal class Swan: Bird
    {
        
        public override string Stats()
        {
            return $"Swan animal is {Ålder} and grow {Vikt} ";
        }
    }

 }
