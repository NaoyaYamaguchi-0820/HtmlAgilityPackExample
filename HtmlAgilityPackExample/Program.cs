using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using HtmlAgilityPack;
using System.Globalization;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {

            var oyaList = new List<List<String>>();
            var koList = new List<String>();

            koList.Add("番号");
            koList.Add("販売価格");
            koList.Add("単価");

            oyaList.Add(koList);
            oyaList.Add(koList);
            oyaList.Add(koList);
            oyaList.Add(koList);

            foreach(List<String> oya in oyaList)
            {

                foreach(String str in oya)
                {
                    //実際は、値をどこかに保持する
                    Console.WriteLine(str);
                }

            }

            for(int i=0; i<=10; i++)
            {
                Console.WriteLine(i);
            }

            //
            //using (var reader = new System.IO.StreamReader(@"C:csvtest.csv", Encoding.GetEncoding("SHIFT_JIS")))
            //using (var csv = new CsvHelper.CsvReader(reader, new CultureInfo("ja-JP", false)))
            //{

            //}

            //----------------------------------------------------

            WebClient web = new WebClient();

            // ここは保存したHTMLファイルのフルパスに書き換える
            string url = @"C:\Users\naoya\Desktop\test.html";
            string htmlstr = web.DownloadString(url);

            if (htmlstr != null)
            {
                var htmlDoc = new HtmlDocument();

                htmlDoc.LoadHtml(htmlstr);
                //HtmlNode n = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='list-a']");
                var list = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='list-a']");
                var nodes1 = list.SelectNodes("./div");

                foreach(var str in nodes1)
                {
                    Console.WriteLine(str.InnerText);
                }

                Console.WriteLine(nodes1.ToString());

            }

            Console.ReadLine();
        }
    }
}
