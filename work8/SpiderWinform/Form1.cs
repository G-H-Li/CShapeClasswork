using Spider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpiderWinform
{
    public partial class Form1 : Form
    {
        Crawler crawler;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCrawl_Click(object sender, EventArgs e)
        {
            string startUrl = tbUrl.Text;
            crawler = new Crawler(startUrl);
            Task<bool>[] tasks = { };
            tbOutput.AppendText("开始爬行了....\r\n");
            DateTime startTime = DateTime.Now;
            while (crawler.Count <= 10)
            {
                string current = null;
                if (crawler.WaitUrls.Count > 0)
                {
                    current = crawler.WaitUrls.Dequeue();
                    if (! crawler.CrawlUrls.ContainsKey(current))
                    {
                        crawler.CrawlUrls.Add(current, false);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
                tbOutput.AppendText("爬取" + current + "页面!\r\n");
                tasks.Append(Task.Run(() => Start(current)));
                tbOutput.AppendText("此链接爬取完毕\r\n");
            }
            tbOutput.AppendText("本次爬取结束\r\n");
            tbOutput.AppendText((DateTime.Now - startTime).ToString() + "\r\n");
        }

        private bool Start(string currentUrl)
        {
            string html = crawler.DownLoad(currentUrl); // 下载页面
            crawler.CrawlUrls[currentUrl] = true; //将爬取过的链接置为已爬取
            crawler.Count++;
            if (!crawler.CheckHtml(html))
            {
                return false;
            }
            if (!crawler.Parse(html))//解析,并加入新的链接
            {
                return false;
            }
            return false;
        }
    }
}
