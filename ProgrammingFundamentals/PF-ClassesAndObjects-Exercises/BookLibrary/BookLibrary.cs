using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class BookLibrary
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var library = new Library
            {
                Name = "BookStore",
                Books = new List<Book>()
            };

            var moneyByAuthor = new Dictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var book = new Book()
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = input[3],
                    ISBNnumber = input[4],
                    Price = double.Parse(input[5])                    
                };
                library.Books.Add(book);
                if (!moneyByAuthor.ContainsKey(book.Author))
                {
                    moneyByAuthor[book.Author] = 0;
                }
                moneyByAuthor[book.Author] += book.Price;
            }
            foreach (var author in moneyByAuthor.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:F2}");
            }
        }
    }
}
