using System;

namespace AulaBalta01POO.ContentContext
{
    internal abstract class Content : Base
    {
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
