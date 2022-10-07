using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaLib
{
    public class Rover
    {
        public int x { get; init; }
        public int y { get; init; }
        public string direction { get; init; }
        public static Plateau plateau;
        public Rover(string startingPoint, Plateau plat)
        {
            string[] all = startingPoint.Split(" ");
            x = int.Parse(all[0]);
            y = int.Parse(all[1]);
            direction = all[2];
            plateau = plat; 
        }
        public Rover(int x, int y, string direction)
        {
            if ((x < plateau.x1) || (y < plateau.y1) || (x > plateau.x2) || (y > plateau.y2))
                throw new ArgumentOutOfRangeException("The Values supplied are out of Range");
            this.x = x;
            this.y = y;
            this.direction = direction;
        }

    }
}
