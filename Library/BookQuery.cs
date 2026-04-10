using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BookQuery
    {
        private BookDatabase db;

        public BookQuery(BookDatabase database)
        {
            db = database;
        }

        // Mövcud kitablar
        public List<Book> GetAvailable()
        {
            return db.GetAll()
                .Where(b => b.GetIsAvailable() == true)
                .ToList();
        }

        public List<Book> GetByGenre(string genre)
        {
            return db.GetAll()
                .Where(b => b.GetGenre() == genre)
                .ToList();
        }

        public List<Book> OrderByTitle()
        {
            return db.GetAll()
                .OrderBy(b => b.GetTitle())
                .ToList();
        }

        public List<Book> OrderByYear()
        {
            return db.GetAll()
                .OrderBy(b => b.GetPublishYear())
                .ToList();
        }

        // Ən köhnə kitab
        public int GetOldestYear()
        {
            return db.GetAll()
                .Min(b => b.GetPublishYear());
        }

        // Ən yeni kitab
        public int GetNewestYear()
        {
            return db.GetAll()
                .Max(b => b.GetPublishYear());
        }

        // Hər hansı bir janr var mı?
        public bool AnyByGenre(string genre)
        {
            return db.GetAll()
                .Any(b => b.GetGenre() == genre);
        }

        public Book GetFirstByGenre(string genre)
        {
            return db.GetAll()
                .FirstOrDefault(b => b.GetGenre() == genre);
        }

        // Listdəki sonuncu kitabı tap
        public Book GetLastAdded()
        {
            return db.GetAll()
                .LastOrDefault();
        }

        // Şərtə uyan sonuncu kitabı tap
        public Book GetLastAvailable()
        {
            return db.GetAll()
                .LastOrDefault(b => b.GetIsAvailable() == true);
        }

        // İlk N kitabı götür
        public List<Book> GetFirstN(int n)
        {
            return db.GetAll()
                .Take(n)
                .ToList();
        }

        // İlk N kitabı keç, qalanını götür
        public List<Book> SkipFirstN(int n)
        {
            return db.GetAll()
                .Skip(n)
                .ToList();
        }

        // Səhifələmə — hər səhifədə N kitab
        public List<Book> GetPage(int pageNumber, int pageSize)
        {
            return db.GetAll()
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        // Bütün unikal janrları götür
        public List<string> GetDistinctGenres()
        {
            return db.GetAll()
                .Select(b => b.GetGenre())
                .Distinct()
                .ToList();
        }

        // Bütün unikal müəllifləri götür
        public List<string> GetDistinctAuthors()
        {
            return db.GetAll()
                .Select(b => b.GetAuthor())
                .Distinct()
                .ToList();
        }
    }
}
