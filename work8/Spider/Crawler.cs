using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Spider
{
    public class Crawler
    {
        //TODO 针对cnblogs上的每个用户博客的爬取文章
        private Hashtable crawlUrls;
        private Queue<string> waitUrls;
        private int count;
        private string startURL;

        public Hashtable CrawlUrls { get => crawlUrls;}
        public Queue<string> WaitUrls { get => waitUrls; }
        public int Count { get => count; set => count = value; }

        public Crawler(string url)
        {
            this.crawlUrls = new Hashtable();
            this.waitUrls = new Queue<string>();
            this.Count = 0;
            this.startURL = url;
            this.WaitUrls.Enqueue(this.startURL);
        }

        public void Crawl()
        {
            DateTime startTime = DateTime.Now;
            Console.WriteLine("开始爬行了.... ");
            while (Count <= 10)
            {
                string current = null;
                if (WaitUrls.Count > 0)
                {
                    current = WaitUrls.Dequeue();
                    if (CrawlUrls.ContainsKey(current))
                    {
                        continue;
                    }
                    else
                    {
                        CrawlUrls.Add(current, false);
                    }
                }
                else
                {
                    break;
                }
                if (current == null) break;
                Console.WriteLine("爬取" + current + "页面!");
                string html = DownLoad(current); // 下载页面
                CrawlUrls[current] = true; //将爬取过的链接置为已爬取
                Count++;
                if (!CheckHtml(html)) continue;
                if (!Parse(html)) break;//解析,并加入新的链接
                Console.WriteLine("爬行结束");
            }
            Console.WriteLine("本次爬取结束");
            Console.WriteLine((DateTime.Now - startTime).ToString());
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = Count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        public bool Parse(string html)
        {
            string strRef = @"(href|HREF)[ ]*=[ ]*[""'][^""'#>]+[""']";
            string start = this.startURL; //只匹配当前作者下的所有文章
            MatchCollection matches = new Regex(strRef).Matches(html);
            if(matches == null) //如果没有找到文章或者html本身就为空
            {
                return false;
            }
            else
            {
                foreach (Match match in matches)
                {
                    strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                              .Trim('"', '\"', '#', '>');
                    if (strRef.Length == 0) continue;
                    if (Regex.IsMatch(strRef, start)) this.WaitUrls.Enqueue(strRef);  //将其加入待爬取队列
                }
                return true;
            }
        }

        public bool CheckHtml(string html)
        {
            string strRef = @"<(html|HTML)[\s\S]*>[\s\S]*</(html|HTML)>";
            if(Regex.IsMatch(html,strRef))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
