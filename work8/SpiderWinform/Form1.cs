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
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCrawl_Click(object sender, EventArgs e)
        {
            string startUrl = tbUrl.Text;
            Crawler crawler = new Crawler(startUrl);
            tbOutput.AppendText("开始爬行了....\r\n");
            while (true)
            {
                string current = null;
                if (crawler.WaitUrls.Count > 0)
                {
                    current = crawler.WaitUrls.Dequeue();
                    if (crawler.CrawlUrls.ContainsKey(current))
                    {
                        continue;
                    }
                    else
                    {
                        crawler.CrawlUrls.Add(current, false);
                    }
                }
                else
                {
                    break;
                }
                if (current == null) break;
                tbOutput.AppendText("爬取" + current + "页面!\r\n");
                string html = crawler.DownLoad(current); // 下载页面
                crawler.CrawlUrls[current] = true; //将爬取过的链接置为已爬取
                crawler.Count++;
                if (!crawler.CheckHtml(html))
                {
                    tbOutput.AppendText("此页面不是html文本\r\n");
                    continue;
                }
                if (!crawler.Parse(html)) break;//解析,并加入新的链接
                tbOutput.AppendText("此链接爬取完毕\r\n");
            }
            tbOutput.AppendText("本次爬取结束\r\n");
        }
    }
}
