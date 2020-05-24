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

        [Fact]
        public void Can_Take_Home_Dog_Not_Cat_Test()
        {
            //arrange
            MyAnimalShelter<Animal> testShelter = new MyAnimalShelter<Animal>();
            cat fluffy = new cat("Fluffy");
            cat whiskers = new cat("Whiskers");
            dog seamus = new dog("Seamus McFearson doodlebug O'Roorda");
            //my Mom named this one ^
            cat socks = new cat("Socks");
            testShelter.ArriveAtShelter<cat>(fluffy);
            testShelter.ArriveAtShelter<cat>(whiskers);
            testShelter.ArriveAtShelter<dog>(seamus);
            testShelter.ArriveAtShelter<cat>(socks);

            //act
            var actual = testShelter.TakeHomeWhich<Animal>("dog");

            //assert
            Assert.Equal(seamus, actual);
        }

        [Fact]
        public void Can_Take_Home_First_Animal_Test()
        {
            //arrange
            MyAnimalShelter<Animal> testShelter = new MyAnimalShelter<Animal>();
            dog jazz = new dog("Jazz");
            cat whiskers = new cat("Whiskers");
            dog seamus = new dog("Seamus McFearson doodlebug O'Roorda");
            //my Mom named this one ^
            cat socks = new cat("Socks");
            testShelter.ArriveAtShelter<dog>(jazz);
            testShelter.ArriveAtShelter<cat>(whiskers);
            testShelter.ArriveAtShelter<dog>(seamus);
            testShelter.ArriveAtShelter<cat>(socks);

            //act
            var actual = testShelter.TakeHomeWhich<Animal>("either");

            //assert
            Assert.Equal(jazz, actual);
        }

        [Fact]
        public void Take_Home_From_Empty_Shelter_Throws_Exception_Test()
        {
            //arrange
            MyAnimalShelter<Animal> testShelter = new MyAnimalShelter<Animal>();

            //Assert
            Assert.Throws<AnimalNotFoundException>(() =>
            {
                //act
                var actual = testShelter.TakeHomeWhich<Animal>("either");
            });

        }
    }

}
