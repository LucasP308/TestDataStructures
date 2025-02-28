//written by Lucas Pautz
//2-26-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndSounds
{
    public class Cat:Animal
    {
        public Cat() : this("n/a") { }
        public Cat(string aName) : base(aName) { }




        override public string MakeSound()
        {
            
            return "Meow";
        }

        public override string ToString()
        {
            string msg = "";
            msg += $"Animal: {Name} Sound: {MakeSound()}";
            return msg;
        }
    }
}
