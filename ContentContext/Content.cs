using System;

namespace Balta.ContentContext
{
    public abstract class Content
    {
        public Content()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public String Title { get; set; }
        public String Url { get; set; }
    }

}