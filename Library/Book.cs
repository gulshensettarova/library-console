using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
         int Id;
         string Title;
         string Author;
         string Genre;
         int PublishYear;
         bool IsAvailable;


        public int GetId() { return Id; }
        public string GetTitle() { return Title; }
        public string GetAuthor() { return Author; }
        public string GetGenre() { return Genre; }
        public int GetPublishYear() { return PublishYear; }
        public bool GetIsAvailable() { return IsAvailable; }

        public void SetId(int id) { Id = id; }
        public void SetTitle(string title) {
            if (title != null) Title = title;
            else Console.WriteLine("basliq null ola bilmez");
        
        }
        public void SetAuthor(string author) { Author = author; }
        public void SetGenre(string genre) { Genre = genre; }
        public void SetPublishYear(int year) { PublishYear = year; }
        public void SetIsAvailable(bool available) { IsAvailable = available; }
    }
}
