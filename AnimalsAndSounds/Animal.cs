//written by Lucas Pautz
//2-26-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndSounds
{
    public class Animal
    {
        private string name = "n/a";

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Animal() : this("n/a") { }
        public Animal(string aName)
        {
            this.name = aName;
        }

        virtual public string MakeSound()
        {
            
            return "Some generic animal sound";
        }

        public override string ToString()
        {
            string msg = "";
            msg += $"Animal: {Name} Sound: {MakeSound()}";
            return msg;
        }

    }
}
