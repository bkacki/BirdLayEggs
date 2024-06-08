using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLayEggs
{
    internal class Egg
    {
        public double Size { get; private set; }
        public string Color { get; set; }

        public Egg (double size, string color)
        {
            Size = size;
            Color = color;
        }

        public string Destription
        { 
            get { return $"{Color} jajo wielkości {Size:0.0} cm.";  }
        }
    }
}
