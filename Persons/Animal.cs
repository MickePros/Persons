using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    internal interface IPerson
    {
        string Talk();
    }
    abstract class Animal
    {
        // F: Arv 14) Om attributet istället berör samtliga djur bör det läggas i klassen Animal.
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Species { get; set; }
        public double Weight { get; set; }

        public abstract string DoSound();

        protected Animal()
        {

        }

        public virtual string Stats()
        {
            string props = "Name, Age, Gender, Species, Weight";
            return props;
        }
    }

    internal class Horse : Animal
    {
        public double TopSpeed { get; set; }
        public override string DoSound()
        {
            return "Neigh";
        }
        public override string Stats()
        {
            string props = base.Stats() + ", TopSpeed";
            return props;
        }
    }

    internal class Dog : Animal
    {
        public string Color { get; set; }
        public override string DoSound()
        {
            return "Bow wow";
        }
        public override string Stats()
        {
            string props = base.Stats() + ", Color";
            return props;
        }
        public string Sit()
        {
            return "Sit, Good boy!";
        }
    }

    internal class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }
        public override string DoSound()
        {
            return "Skitter";
        }
        public override string Stats()
        {
            string props = base.Stats() + ", NrOfSpikes";
            return props;
        }
    }

    internal class Worm : Animal
    {
        public bool IsSlimy { get; set; }
        public override string DoSound()
        {
            return "Slitter";
        }
        public override string Stats()
        {
            string props = base.Stats() + ", IsSlimy";
            return props;
        }
    }

    internal class Bird : Animal
    {
        // F: Arv 13) Behöver vi lägga till attribut som berör samtliga fåglar bör detta läggas till i klassen Bird.
        public bool IsTropical { get; set; }
        public override string DoSound()
        {
            return "Scree";
        }
        public override string Stats()
        {
            string props = base.Stats() + ", IsTropical";
            return props;
        }
    }

    internal class Wolf : Animal
    {
        public bool IsAlpha { get; set; }
        public override string DoSound()
        {
            return "Awuu";
        }
        public override string Stats()
        {
            string props = base.Stats() + ", IsAlpha";
            return props;
        }
    }
    internal class Pelican : Bird
    {
        public double BeakSize { get; set; }
    }
    internal class Flamingo : Bird
    {
        public string Diet { get; set; }
    }
    internal class Swan : Bird
    {
        public bool IsMated { get; set; }
    }
    internal class Wolfman : Wolf, IPerson
    {
        public string Talk()
        {
            return "Time to die";
        }
    }
}
