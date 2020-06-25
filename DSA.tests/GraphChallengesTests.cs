using DataStructures.myGraph;
using DSA.GraphChallenges;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DSA.tests
{
   public class GraphChallengesTests
    {
        [Fact]
        //[InlineData(new[] { "Metroville", "Pandora," }, new TripResult(true, 82))]
        public void Airplane_Trip_Test()
        {
            //arrange
            myGraph<string> testFlight = new myGraph<string>();
            var pandora = testFlight.AddVertex("Pandora");
            var metroville = testFlight.AddVertex("Metroville");
            var narnia = testFlight.AddVertex("Narnia");
            var arendelle = testFlight.AddVertex("Arendelle");
            var naboo = testFlight.AddVertex("Naboo");
            var monstropolis = testFlight.AddVertex("Monstropolis");
            testFlight.AddEdge(pandora, metroville, 82);
            testFlight.AddEdge(pandora, arendelle, 150);
            testFlight.AddEdge(narnia, metroville, 37);
            testFlight.AddEdge(narnia, naboo, 250);

            testFlight.AddEdge(narnia, monstropolis, 73);
            testFlight.AddEdge(naboo, metroville, 26);
            testFlight.AddEdge(arendelle, metroville, 99);
            testFlight.AddEdge(arendelle, monstropolis, 42);

            testFlight.AddEdge(monstropolis, metroville, 105);
            TripResult expected = new TripResult(true, 82);
            string[] stops = new string[] { "Metroville", "Pandora" };

            //act
            TripResult actual = GraphChallenges.GraphChallenges.PlaneTrip(testFlight, stops);

            //Assert
            Assert.Equal(expected.cost, actual.cost);


        }
    }
}
