using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Init.");

            //create authors list
            List<Author> authors = new List<Author>();
            
            //create books list
            List<Book> books = new List<Book>();

            List<Book> oldbooks = new List<Book>();

            //add elements to authors list
            authors.Add(new Author() { Id = 0, Name = "Terry Prathet" });
            authors.Add(new Author() { Id= 1, Name="Frank Herbert"});

            Author author1 = new Author() { Id = 2, Name = "Henryk Sienkiewicz" };

            authors.Add(author1);

            //add elements to books list

            Book book1 = new Book() {
                Id = 0,
                Name = "Kolor Magii",
                PublicationDate = DateTime.Today.AddMonths(-48),
                AuthorId = 0
            };
            Book book2 = new Book() {
                Id = 1,
                Name = "Blask Fantastyczny",
                PublicationDate = DateTime.Today.AddMonths(-40),
                AuthorId = 0
            };
            Book book3 = new Book() {
                Id = 2, Name = "Wiedźmikołaj",
                PublicationDate = DateTime.Today.AddMonths(-40),
                AuthorId = 0
            };
            Book book4 = new Book() {
                Id = 3, Name = "Straż! Straż!",
                PublicationDate = DateTime.Today.AddMonths(-40),
                AuthorId = 0
            };
            Book book5 = new Book() {
                Id = 4, Name = "Diuna",
                PublicationDate = DateTime.Today.AddMonths(-30),
                AuthorId = 1 };

            Book book6 = new Book() {
                Id = 5,
                Name = "Dzieci Diuny",
                PublicationDate = DateTime.Today.AddMonths(-20),
                AuthorId = 1
            };
            var book7 = new Book()
            {
                Id = 6,
                Name = "Ogniem i Mieczem",
                PublicationDate = DateTime.Today.AddMonths(-60),
                AuthorId = 2
            };

            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
            books.Add(book5);
            books.Add(book6);
            books.Add(book7);

          

            Console.WriteLine(string.Format("Ilość książek: {0}", books.Count));
            Console.WriteLine(string.Format("Ilość autorów: {0}", authors.Count));
            Console.WriteLine();
            string s;
            //s = Console.ReadLine();
            //Console.WriteLine(string.Format("Szukam i = {0}", s));

            var search = books.Find(book => book.Id == 153);

            var search2 = books.Where(b => b.Id == 2 || b.Id == 6);

            var search3 = books.Where(b => b.Id == 2 || b.Id == 6);

           
            //List Books
            for(var i = 0; i< books.Count; i++)
            {

                Console.WriteLine(books[i].Name);
            }
            Console.WriteLine();


            //List Authors
            foreach (var a in authors)
            {
                Console.WriteLine(a.Name);

            }

            var search4 = oldbooks.SingleOrDefault()



            //
            Console.ReadLine();

        }
    }
}
