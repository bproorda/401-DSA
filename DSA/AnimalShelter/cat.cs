using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.AnimalShelter
{
   public  class cat : Animal
    {

        public override string Name { get; set; }
        public override bool IsGoodNotEvil { get => false; }

        public cat(string name)
        {
            Name = name;
        }
    }
}
