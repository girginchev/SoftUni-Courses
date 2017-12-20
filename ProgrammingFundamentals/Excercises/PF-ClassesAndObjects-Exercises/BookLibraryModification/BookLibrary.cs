using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BookLibraryModification
{
    public class BookLibrary
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var library = new Library("Viktor's Library");

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var name = input[0];
                var author = input[1];
                var publisher = input[2];
                var releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var isbnNumber = input[4];
                var price = decimal.Parse(input[5]);
                var book = new Book(name, author, publisher, releaseDate, isbnNumber, price);
                library.Books.Add(book);
            }
            var givenDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InstalledUICulture);

            foreach (var books in library.Books.OrderBy(d=>d.ReleaseDate).ThenBy(t=>t.Title))
            {
                if (books.ReleaseDate > givenDate)
                {
                    Console.WriteLine($"{books.Title} -> {books.ReleaseDate:dd.MM.yyyy}");
                }
            }

        }
    }
}
