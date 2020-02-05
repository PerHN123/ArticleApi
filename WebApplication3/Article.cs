using System;

namespace ArticleApp
{
    public class Article
    {
        public Article()
        {

        }
        public Article(int id, string author, string title, string text, int year)
        {
            Id = id;
            Author = author;
            Title = title;
            Text = text;
            Year = year;
        }
        public int Id { get; set; }
        public string Author { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public int Year { get; set; }
    }
}
