using System;

namespace Balta.ContentContext
{
    public abstract class Content
    {
        public Content(string title, string url)
        {
            Id = Guid.NewGuid();
            Title = title;
            Url = url;
        }

        public Guid Id { get; set; }
        public String Title { get; set; }
        public String Url { get; set; }
    }

}