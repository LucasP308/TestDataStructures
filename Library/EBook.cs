//written by Lucas Pautz
//2-26-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class EBook:Book
    {
        private string sizeMB = "0";

        public string Size
        {
            get { return this.sizeMB; }
            set { this.sizeMB = value; }
        }

        public EBook(string aTitle, string anAuthor, string aYear, string aSize):base(aTitle, anAuthor, aYear)
        {
            this.sizeMB = aSize;
        }


        public override string ToString()
        {
            string msg = "";

            msg += $"E-Book:{Title} by {Author} published in {Year} is size: {Size}mb\n";
            return msg;
        }
    }
}
