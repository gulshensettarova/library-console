using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
    

            BookDatabase db = new BookDatabase();

            Book b1 = new Book();
            b1.SetId(1);
            b1.SetTitle("Ali and Nino");
            b1.SetAuthor("Kurban Said");
            b1.SetGenre("Novel");
            b1.SetPublishYear(1937);
            b1.SetIsAvailable(true);


            Book b2 = new Book();
            b2.SetId(2);
            b2.SetTitle("The Dead");
            b2.SetAuthor("Jalil M.");
            b2.SetGenre("Comedy");
            b2.SetPublishYear(1909);
            b2.SetIsAvailable(false);

            Book b3 = new Book();
            b3.SetId(3);
            b3.SetTitle("Dada Gorgud");
            b3.SetAuthor("Anonymous");
            b3.SetGenre("Epic");
            b3.SetPublishYear(2003);
            b3.SetIsAvailable(true);

            db.Add(b1);
            db.Add(b2);
            db.Add(b3);

            // 4. Bütün kitabları foreach ilə göstər
            foreach (Book b in db.GetAll())
            {
                Console.WriteLine(b.GetTitle() + " — " + b.GetAuthor());
            }

            // 5. Id ilə tap
            Book found = db.FindById(2);
            Console.WriteLine("Found: " + found.GetTitle());

            //6.Id ilə sil
            db.RemoveById(2);
            Console.WriteLine("Count after remove: " + db.Count());


            //BookQuery query = new BookQuery(db);

            // 7. LINQ sorğuları
            //List<Book> available = query.GetAvailable();
            //List<Book> novels = query.GetByGenre("Novel");
            //bool hasEpic = query.AnyByGenre("Epic");
            //int oldest = query.GetOldestYear();
            //int newest = query.GetNewestYear();

            ////8
            //Book firstNovel = query.GetFirstByGenre("Novel");

            //if (firstNovel != null)
            //    Console.WriteLine(firstNovel.GetTitle());
            //else
            //    Console.WriteLine("Not found");

            //Book last = query.GetLastAdded();
            //Console.WriteLine("Last added: " + last.GetTitle());


            ////9. Skip | Take

            //List<Book> first2 = query.GetFirstN(2);
            //List<Book> skip2 = query.SkipFirstN(2);

            //     // Səhifə 1 — 2 kitab per səhifə
            //List<Book> page1 = query.GetPage(1, 2);

            //        // Səhifə 2 — 2 kitab per səhifə
            //List<Book> page2 = query.GetPage(2, 2);

            ////10. Distinct 
            //List<string> genres = query.GetDistinctGenres();
            //List<string> authors = query.GetDistinctAuthors();

        }
    }
}
