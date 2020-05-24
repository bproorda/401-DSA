using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DSA.AnimalShelter;

namespace DSA.tests
{
   public  class AnimalShelterTests
    {
        [Fact]

        public void Can_Create_Empty_Shelter_Test()
        {
            //act
            MyAnimalShelter<dog> testShelter = new MyAnimalShelter<dog>();

            //Assert
            Assert.NotNull(testShelter);
        }

        [Fact]

        public void Shelter_Can_Take_Animal_Test()
        {
            //arrange
            MyAnimalShelter<dog> testShelter = new MyAnimalShelter<dog>();
            dog dakota = new dog("Dakota");

            //act
            testShelter.ArriveAtShelter<dog>(dakota);

            //Assert
            Assert.Equal("Dakota", testShelter.Front.Value.Name);

        }

        [Fact]

        public void Shelter_Can_Take_Multiple_Animals_Test()
        {
            //arrange
            MyAnimalShelter<dog> testShelter = new MyAnimalShelter<dog>();
            dog dakota = new dog("Dakota");
            dog drew = new dog("Drew");
            dog dutch = new dog("Dutch");

            //act
            testShelter.ArriveAtShelter<dog>(dakota);
            testShelter.ArriveAtShelter<dog>(drew);
            testShelter.ArriveAtShelter<dog>(dutch);

            //Assert
            Assert.Equal("Dakota", testShelter.Front.Value.Name);
            Assert.Equal("Dutch", testShelter.Rear.Value.Name);

        }
    }
}
