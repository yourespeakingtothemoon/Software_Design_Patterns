using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackpackBackpackBackpackBackpackYeah.Interfaces;

namespace BackpackBackpackBackpackBackpackYeah.Items
{
    internal class Book : Interfaces.IItem
    {
        private string BookName;
        public Book(string BookName) {
        this.BookName = BookName;
        }
        public string? Name()
        {
            return BookName;
        }

    }
    
    
}
