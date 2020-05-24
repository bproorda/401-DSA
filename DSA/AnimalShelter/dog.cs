using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.AnimalShelter
{
    public class dog : Animal
    {
        public override string Name { get; set; }
        public override bool IsGoodNotEvil { get => true; }

        public dog(string name)
        {
            Name = name;
        }
    }
}
