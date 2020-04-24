using Spider;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string startUrl = "https://www.cnblogs.com/Xy--1/";
            Crawler myCrawler = new Crawler(startUrl);
            myCrawler.Crawl();
        }
    }
}
