using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLayEggs
{
    internal class Bird
    {
        public static Random Randomizer = new Random();
        public virtual Egg[] LayEggs(int numberOfEggs)
        {
            Console.Error.WriteLine("Metoda Bird.LayEggs nie powinna być wywoływana.");
            return new Egg[0];
        }
    }

    internal class Pigeon : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
                eggs[i] = new Egg(Randomizer.Next(10,31)*0.1F, "Białe");

            return eggs;
        }
    }

    internal class Ostrich : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
                eggs[i] = new Egg(Randomizer.Next(120, 131)*0.1F, "Nakrapiane");

            return eggs;
        }
    }
}
