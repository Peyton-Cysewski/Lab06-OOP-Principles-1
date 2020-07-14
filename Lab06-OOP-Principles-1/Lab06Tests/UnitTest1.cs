using System;
using Xunit;
using Lab06_OOP_Principles_1.classes;
using System.Runtime.InteropServices;

namespace Lab06Tests
{
    public class UnitTest1
    {
        [Fact]
        public void PolarBearInheritsFromMammal()
        {
            // Arrange
            PolarBear whitey = new PolarBear();
            // Act
            bool actual = whitey.IsTamable;
            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void DogInheritsFromAnimal()
        {
            // Arrange
            Dog skip = new Dog();
            // Act
            string actual = skip.Eating();
            string expected = "Nom nom nom...";
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CrocodileInheritsFromAnimal()
        {
            // Arrange
            Crodocile scaly = new Crodocile();
            // Act
            int actual = scaly.Age;
            int expected = 0;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LizardInheritsFromReptile()
        {
            // Arrange
            Lizard liz = new Lizard();
            // Act
            bool actual = liz.LaysEggs;
            // Assert
            Assert.False(actual);
        }

        [Fact]
        public void BearInheritsFromAnimal()
        {
            // Arrange
            Bear beary = new Bear();
            // Act
            int actual = beary.Age;
            int expected = 0;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BearEatingReturnsString()
        {
            // Arrange
            Bear bearo = new Bear();
            // Act
            string actual = bearo.Eating();
            string expected = "*Indistinct Screaming*";
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BearSleepingReturnsString()
        {
            // Arrange
            Bear bearo = new Bear();
            // Act
            string actual = bearo.Sleeping();
            string expected = "Zzzzzzzzz...";
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BearLivingReturnsString()
        {
            // Arrange
            Bear bearo = new Bear();
            // Act
            string actual = bearo.Living();
            string expected = "Dreaming about eating a herbivore...";
            // Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void BearLikeableScaleReturnsInt()
        {
            // Arrange
            Bear bearo = new Bear();
            // Act
            int actual = bearo.LikeableScale();
            int expected = 9000;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BearPettableScaleReturnsInt()
        {
            // Arrange
            Bear bearo = new Bear();
            // Act
            int actual = bearo.PettableScale();
            int expected = 900000;
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LizardLayingEggsReturnsString()
        {
            // Arrange
            Lizard lizzy = new Lizard();
            // Act
            string actual = lizzy.LayingEggs();
            string expected = "Whoops, that\'s not an egg...";
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LizardEatingHumansReturnsString()
        {
            // Arrange
            Lizard lizzy = new Lizard();
            // Act
            string actual = lizzy.EatingHumans();
            string expected = "They are saltier than I remember!";
            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
