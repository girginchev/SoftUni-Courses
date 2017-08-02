using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryModification
{
    public class Library
    {
        public Library(string name)
        {
            this.Name = name;
            this.Books = new List<Book>();
        }
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
