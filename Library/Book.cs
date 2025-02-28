//written by Lucas Pautz
//2-26-2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        private string title = "n/a";
        private string author = "n/a";
        private string yearPublished = "n/a";

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }
    
        public string Year
        {
            get { return this.yearPublished; }
            set { this.yearPublished = value; }
        }

        public Book() : this("n/a", "n/a", "n/a") { }
        public Book(string aTitle, string anAuthor, string aYear)
        {
            this.title = aTitle;
            this.author = anAuthor;
            this.yearPublished= aYear;
        }



        public override string ToString()
        {
            string msg = "";
            msg += $"{Title} by {Author} published in {Year}\n";
            return msg;
        }
    }
}
