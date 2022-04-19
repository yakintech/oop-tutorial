using System;

namespace CSharpOOP.BlogSample
{
    public class BlogComment : BlogBaseModel
    {

        public BlogComment(string title, string content)
        {
            this.Title = title;
            this.Content = content;

        }

        public BlogPost BlogPost { get; set; }

        public User User { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

    }
}
