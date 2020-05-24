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
    }
}
