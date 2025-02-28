//written by Lucas Pautz
//2-26-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class PrintedBook:Book
    {
        private string numPage = "0";

        public string Pages
        {
            get { return this.numPage; }
            set { this.numPage = value; }
        }

        public PrintedBook(string aTitle, string anAuthor, string aYear, string aPages) : base(aTitle, anAuthor, aYear)
        {
            this.numPage = aPages;
        }


        public override string ToString()
        {
            string msg = "";

            msg += $"The printed book:{Title} by {Author} published in {Year} is {Pages} pages long\n";
            return msg;
        }
    }
}
