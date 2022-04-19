using System;
using CSharpOOP.BlogSample;

namespace CSharpOOP.NewsSample
{
    public class News
    {

        //Title -> Helper kullanılacak
        //Content -> String bir property
        //SubContent -> Contentteki değerin ilk 100 karakteri otomatik subcontent olacak subcontent ayrıca kullanıcı tarafından set edilmeyecek!!
        //AdminUser -> class


        //public News()
        //{
        //    Content = "";
        //}

        string name = "";

        public string Name {
            get
            {
                return name;
            }
            set {
                name = getThreeChar(value);
            }

        }

        //string _EMail = "";
        //public string EMail { get => _EMail; set => _EMail = value.ToLower(); }



        private string title = "";

        public string Title
        {
            get
            {
                return BlogHelper.TitleCapitalize(title);
            }
            set
            {
                title = value;
            }
        }


        public string Content { get; set; } = "";


        public string SubContent {
            get
            {
                //if (Content != null)
                //{
                    if (Content.Length < 100)
                    {
                        return Content;
                    }
                    else
                    {
                        return Content.Substring(0, 100);
                    }
                //}
                //else
                //{
                //    return "";
                //}
               
              
              
            }
        }


        public AdminUser AdminUser { get; set; }


        string getThreeChar(string word)
        {
            if (word.Length >= 3)
            {
                return word.Substring(0, 3);
            }
            else
            {
                return word;
            }
        }

    }
}
