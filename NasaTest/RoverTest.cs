
using NasaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaTest
{

   
    public class RoverTest
    {
        [Theory]
        [InlineData("1 2 N","W")]
        [InlineData("1 2 E", "N")]
        [InlineData("1 2 S", "E")]
        [InlineData("1 2 W", "S")]
        public void Rover_SpinLeft_Shoult_SpinLeft_Whentgiven(string input ,string direction)
        {
            //Arrange
            var plateau = new Plateau(0, 0, 5, 5);
            Rover rover = new Rover(input,plateau);

            //Act


            var result = rover.SpinLeft();

            //Assert
            Assert.True(direction==result.direction );
            Assert.Equal(direction, result.direction);

        }


        [Theory]
        [InlineData("1 2 N", "E")]
        [InlineData("1 2 E", "S")]
        [InlineData("1 2 S", "W")]
        [InlineData("1 2 W", "N")]
        public void Rover_SpinLeft_Shoult_SpinRight_Whentgiven(string input, string direction)
        {
            //Arrange
            var plateau = new Plateau(0, 0, 5, 5);
            Rover rover = new Rover(input, plateau);

            //Act


            var result = rover.SpinRight();

            //Assert
            Assert.True(direction == result.direction);
            Assert.Equal(direction, result.direction);

        }




        [Theory]
        [InlineData("1 2 N", 1, 3,"N")]
        [InlineData("1 2 E", 2, 2 ,"E")]
        [InlineData("1 2 S", 1 ,1 ,"S")]
        [InlineData("1 2 W", 0 ,2 ,"W")]
        public void Rover_StepForward_Shoult_SpinRight_Whentgiven(string input, int x,int y, string z)
        {
            //Arrange
            var plateau = new Plateau(0, 0, 5, 5);
            Rover rover = new Rover(input, plateau);

            //Act


            var result = rover.StepForward();

            //Assert
            Assert.True(y == result.y);
            Assert.True(x == result.x);
            Assert.Equal(z, result.direction);

        }

        [Theory]
        [InlineData( "LMLMLMLMM", "1 2 N","1 3 N" )]
        [InlineData("MMRMMRMRRM", "3 3 E", "5 1 E")]

        public void Move(string moveTo,string input, string output)
        {
            //Arrange
            var plateau = new Plateau(0, 0, 5, 5);
            Rover rover = new Rover(input, plateau);

            //Act

            var result = rover.Move(moveTo);
          

            //Assert
            Assert.True(output == result.x+" "+result.y+" "+result.direction);
           // Assert.True(x == result.x);
           // Assert.Equal(z, result.direction);

        }

    }
}
