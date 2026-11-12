using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTests
{
    public class MathTests
    {
        public void NazwaMetodyKtoraTestujemy_Scenariusza_OczekiwanyRezultat()
        {
            //arrange


            //act

            //assert

        }

        [Theory]
        [InlineData(9, 3)]
        [InlineData(16, 5)]
        [InlineData(25, 5)]
        public void Sqrt_PositivePerfectSquare_ReturnsSquareRoot(double number, double expected)
        {
            //arrange

            //act
            double result = Math.Sqrt(number);

            //assert
            Assert.Equal(expected, result);

        }


    }
}
