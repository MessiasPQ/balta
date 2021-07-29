using System;
using System.Collections.Generic;
using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.ContentContext
{
    public abstract class Content : Base
    {
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }

        public String Title { get; set; }
        public String Url { get; set; }
    }

}