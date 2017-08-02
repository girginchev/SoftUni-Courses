using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BookLibrary
{
    public class BookLibrary
    {
        public static void Main()
        {
            var lines = File.ReadAllLines(@"..\..\input.txt");
            var books = new List<Book>();
            foreach (var line in lines)
            {
                var tokens = line.Split();
                var title = tokens[0];
                var author = tokens[1];
                var publisher = tokens[2];
                var relieseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var isbn = tokens[4];
                var price = double.Parse(tokens[5]);
                var book = new Book
                {
                    Title = title,
                    Author = author,
                    Publisher = publisher,
                    RealeaseDate = relieseDate,
                    ISBN = isbn,
                    Price = price
                };
                books.Add(book);
            }
            var library = new Library
            {
                Name = "Viktor's Library",
                Books = books
            };
            //var moneyEarnedByAuthor = new Dictionary<string, double>();
            //foreach (var book in library.Books)
            //{
            //    if (!moneyEarnedByAuthor.ContainsKey(book.Author))
            //    {
            //        moneyEarnedByAuthor[book.Author] = 0;
            //    }
            //    moneyEarnedByAuthor[book.Author] += book.Price;
            //}
            //foreach (var author in moneyEarnedByAuthor.OrderByDescending(x=>x.Value).ThenBy(a=>a.Key))
            //{
            //    var result = string.Format($"{author.Key} -> {author.Value:F2}{Environment.NewLine}");
            //    File.AppendAllText(@"../../result.txt", result);
            //}
            var givenDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in library.Books.OrderBy(x=> x.RealeaseDate).ThenBy(b=>b.Title))
            {
                if (book.RealeaseDate >= givenDate)
                {
                    var result = string.Format($"{book.Title} -> {book.RealeaseDate:dd.MM.yyyy}{Environment.NewLine}");
                    File.AppendAllText(@"..\..\booksByDates.txt", result);
                }
            }
        }
    }
}
