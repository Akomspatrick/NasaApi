using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaLib
{
    public static class RoverExtensions
    {
        public static Rover SpinLeft(this Rover rover)
        {
            Rover nn = rover.direction switch
            {
                "N" => new Rover(rover.x, rover.y, "W"),
                "E" => new Rover(rover.x, rover.y, "N"),
                "S" => new Rover(rover.x, rover.y, "E"),
                "W" => new Rover(rover.x, rover.y, "S"),
                _ => rover
            };
            return nn;
        }


        public static string PresentLocation(this Rover rover)
        {

            return $"{rover.x} {rover.y} {rover.direction}";
        }
        public static Rover SpinRight(this Rover rover)
        {
            Rover nn = rover.direction switch
            {
                "N" => new Rover(rover.x, rover.y, "E"),
                "E" => new Rover(rover.x, rover.y, "S"),
                "S" => new Rover(rover.x, rover.y, "W"),
                "W" => new Rover(rover.x, rover.y, "N"),
                _ => rover
            };
            return nn;
        }


        public static Rover StepForward(this Rover rover)
        {
            Rover nn = rover.direction switch
            {
                "N" => new Rover(rover.x, rover.y + 1, rover.direction),
                "E" => new Rover(rover.x + 1, rover.y, rover.direction),
                "S" => new Rover(rover.x, rover.y - 1, rover.direction),
                "W" => new Rover(rover.x - 1, rover.y, rover.direction),
                _ => rover
            };
            return nn;
        }

        public static Rover Move(this Rover rover, string path)
        {
            Rover rv = new Rover(rover.x, rover.y, rover.direction);
            foreach (var x in path)
            {
                rv = GetMovement(rv, x);

            }
            return rv;
        }

        private static Rover GetMovement(Rover rv, char x)
        {
            Rover newRover = x switch
            {
                'L' => rv.SpinLeft(),
                'R' => rv.SpinRight(),
                'M' => rv.StepForward(),
                _ => rv
            };
            return newRover;
        }
    }
}
