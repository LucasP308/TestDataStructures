//written by Lucas Pautz
//2-26-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndSounds
{
    public class Dog:Animal
    {
        public Dog() : this("n/a") { }
        public Dog(string aName):base(aName) { }
        
            
        

         override public string MakeSound()
        {
            
            return "Bark";
        }

        public override string ToString()
        {
            string msg = "";
            msg += $"Animal: {Name} Sound: {MakeSound()}";
            return msg;
        }

    }
}

