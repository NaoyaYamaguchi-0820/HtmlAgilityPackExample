using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using HtmlAgilityPack;

namespace wettest
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient web = new WebClient();

            // ここは保存したHTMLファイルのフルパスに書き換える
            string url = @"C:\Users\naoya\Desktop\阿部寛のホームページ.html";
            string htmlstr = web.DownloadString(url);

            if (htmlstr != null)
            {
                var htmlDoc = new HtmlDocument();

                htmlDoc.LoadHtml(htmlstr);
                HtmlNode n = htmlDoc.DocumentNode.SelectSingleNode(@"/html/head/title");
                Console.WriteLine(n.InnerText);

            }

            Console.ReadLine();
        }
    }
}
