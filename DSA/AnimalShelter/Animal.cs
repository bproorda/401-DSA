using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.AnimalShelter
{
    public abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract bool  IsGoodNotEvil { get; }
    }
}
