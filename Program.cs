using System;
using System.Collections.Generic;

namespace DynamicArray
{
    class Book
    {
        public string title {get; set;}
    }

    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<Book> books = new DynamicArray<Book>
            {
                new Book {title = "The Last Wish"},
                new Book {title = "The Song Of Ice and Fire"},
            };

            books.Add(new Book{title = "Lord Of The Rings"});
            books.RemoveAt(1);

            for(int i = 0; i < books.Size; i++)
            {
                Console.WriteLine(books[i].title);
            }
        }
    }
}
