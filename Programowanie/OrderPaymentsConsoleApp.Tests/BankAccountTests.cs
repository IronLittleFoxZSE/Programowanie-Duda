using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPaymentsConsoleApp.Tests
{
    public class BankAccountTests
    {
        //[Fact]

        //[Theory]
        //[InlineData(0)]
        //void NazwaMetodyTestowanej_Scenariusz_CoOczekujemy(/*parametry*/)
        //{
        //Arrange (przygotowanie)

        //Act (wykonanie)

        //Assert (sprawdzenie)

        //}

        [Theory]
        [InlineData(15)]
        [InlineData(18)]
        [InlineData(0)]
        public void BankAccount_PositiveInitialBalnce_SetBalane(decimal initialBalance)
        {
            //Arrange (przygotowanie)
            BankAccount bankAccount;

            //Act (wykonanie)

            bankAccount = new BankAccount(initialBalance);

            //Assert (sprawdzenie)
            Assert.Equal(initialBalance, bankAccount.Balance);
        }

        [Theory]
        [InlineData(-15)]
        [InlineData(-187)]
        //[InlineData(187)]
        public void BankAccount_NegativeInitialBalnce_GetArgumentOutOfRangeException(decimal initialBalance)
        {
            //Arrange (przygotowanie)
            BankAccount bankAccount;

            //Act (wykonanie)
            Action testAction = () => bankAccount = new BankAccount(initialBalance);

            //Assert (sprawdzenie)
            Assert.Throws<ArgumentOutOfRangeException>(testAction);
        }

    }
}
