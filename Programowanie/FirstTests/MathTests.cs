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

        [Fact]
        public void Sqrt_PositivePerfectSquare_ReturnsSquareRoot()
        {
            //arrange
            double number = 9;

            //act
            double result = Math.Sqrt(number);

            //assert
            Assert.Equal(3, result);

        }
    }
}
