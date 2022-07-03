using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using HtmlAgilityPack;

namespace Teser
{
    public class Html
    {
        public void CreateLinks()
        {
            string http =
                $"http://www.udmbti.ru/?kadN=18%3A26%3A010065%3A77________&btn=Узнать+кадастровую+стоимость+объекта#top-c";
            string l = "</span><br />Дата оценки: <span style=\"color: #3399ff;\">";
            WebRequest req = WebRequest.Create(@"" + http);
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string text = sr.ReadToEnd();
            text = text.Substring(text.IndexOf(l), l.Length + 10);
            text = text.Remove(0, l.Length);


            Console.WriteLine(text);
        }
    }
}