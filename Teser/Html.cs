using System;
using System.Collections.Generic;
using HtmlAgilityPack;

namespace Teser
{
    public class Html
    {
        // я в другом проекте пробовал взят ьинфу с сайта
        // но не смог попробуй погуглить и может найдешь проблему
        // сам сайт скачивается но в строку не записывается содержимое контейнера(div)
        //может сможешь сделать с помощью API может доработаешь те варики которые я скинул сюда

        const string classObject = "report-dictionary";
        List<string> abc = new List<string>();
        string url = @"https://egrnreestor.ru/search/18:26:010065:77?query=18%3A26%3A010065%3A77&metricId=7516441";

        /*
        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load(url);
        foreach (HtmlNode node in doc.DocumentNode.SelectNodes($"//div[@class='{classObject}']"))
        {
            abc.Add( node.ChildNodes[0].InnerHtml);
        }

        foreach (var a in abc)
        {
            Console.WriteLine(a);
        }
        */

        /*
        HtmlAgilityPack.HtmlDocument HD = new HtmlAgilityPack.HtmlDocument();
        HD.LoadHtml(url);
        var result = string.Empty;
        result += HD.DocumentNode.SelectSingleNode($"//div[@class='{classObject}']//dd[@class='report-dictionary__value']").GetDirectInnerText();

        Console.WriteLine(result);
        */

        /*
        const string classObject = "report-dictionary__value";
        string url = "https://egrnreestor.ru/search/18:26:010065:77?query=18%3A26%3A010065%3A77";

        HtmlWeb webSite = new HtmlWeb();
        HtmlDocument doc =  webSite.Load($"{url}");
        var result = string.Empty;
        result += doc.DocumentNode.SelectNodes("//div[contains(@class,'report-dictionary')]");
        Console.WriteLine(result);
        */


        /*
        HtmlWeb webSite = new HtmlWeb();
        HtmlDocument document = webSite.Load("http://www.tibia.com/news/?subtopic=latestnews");
        string content = document.GetElementbyId("PlayersOnline").OuterHtml;
        //Console.WriteLine(content);
        

        /*
         var web = new HtmlWeb();
        web.OverrideEncoding = Encoding.UTF8;
        HtmlDocument doc = web.Load(url);

        List<string> abc = new List<string>();

        HtmlNode node = doc.DocumentNode.SelectSingleNode($"//div[@class='{classObject}']");

        abc.Add(node.ChildNodes[0].InnerHtml);


        foreach (var a in abc)
        {
            Console.WriteLine(a);
        }*/
    }
}