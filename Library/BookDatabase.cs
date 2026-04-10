using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BookDatabase
    {
        private List<Book> books = new List<Book>();

        // Əlavə et
        public void Add(Book book)
        {
            books.Add(book);
        }

        public void RemoveById(int id)
        {
            Book found = null;

            foreach (Book b in books)
            {
                if (b.GetId() == id)
                {
                    found = b;
                    break;
                }
            }
            if (found != null)
            {
                books.Remove(found);
            }
        }
        public List<Book> GetAll()
        {
            return books;
        }


        public Book FindById(int id)
        {
            foreach (Book b in books)
            {
                if (b.GetId() == id)
                {
                    return b;
                }
            }
            return null;
        }

        public Book FindByTitle(string title)
        {
            foreach (Book b in books)
            {
                if (b.GetTitle() == title)
                {
                    return b;
                }
            }
            return null;
        }

        // Neçə kitab var?
        public int Count()
        {
            return books.Count;
        }
    }
}
