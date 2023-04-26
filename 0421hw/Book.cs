using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0421hw
{
    internal class Book
    {
        public int LibraryCardCode { get;set; }
        public string Authors { get;set; }
        public string Title { get;set; }
        public string Publisher { get;set; }
        public int Year { get;set; }
        public DateTime Taken { get;set; }
        public DateTime Expire { get;set; }
        public Book(int libraryCardCode, string authors, string title, string publisher, int year, DateTime taken, DateTime expire)
        {
            LibraryCardCode = libraryCardCode;
            Authors = authors;
            Title = title;
            Publisher = publisher;
            Year = year;
            Taken = taken;
            Expire = expire;
        }
    }
}
