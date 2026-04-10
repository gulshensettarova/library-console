using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public int Id;
        public string Title;
        public string Author;
        public string Genre;
        public int PublishYear;
        public bool IsAvailable;


        public int GetId() { return Id; }
        public string GetTitle() { return Title; }
        public string GetAuthor() { return Author; }
        public string GetGenre() { return Genre; }
        public int GetPublishYear() { return PublishYear; }
        public bool GetIsAvailable() { return IsAvailable; }

        public void SetId(int id) { Id = id; }
        public void SetTitle(string title) { Title = title; }
        public void SetAuthor(string author) { Author = author; }
        public void SetGenre(string genre) { Genre = genre; }
        public void SetPublishYear(int year) { PublishYear = year; }
        public void SetIsAvailable(bool available) { IsAvailable = available; }
    }
}
