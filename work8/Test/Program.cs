using Spider;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string startUrl = "https://www.cnblogs.com/dstang2000/";
            Crawler myCrawler = new Crawler(startUrl);
            myCrawler.Crawl();
        }
    }
}
