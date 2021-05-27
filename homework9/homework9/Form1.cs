using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework9
{
    public partial class Form1 : Form
    {
        SimpleCrawler crawler = new SimpleCrawler();
        BindingSource crawlerResultBindingSource = new BindingSource();
        Thread thread = null;
        public Form1()
        {
            InitializeComponent();
            dgv_result.DataSource = crawlerResultBindingSource;
            crawler.CrawlerEnding += crawler_Ending;
            crawler.ThisPageDownloaded += crawler_Downloaded;
        }
        private void crawler_Ending(SimpleCrawler crawler)
        {
            lbl_message.Text = "停止爬取";
        }
        private void crawler_Downloaded(SimpleCrawler crawler, string url, string message)
        {
            var pageInfo = new { Index = crawlerResultBindingSource.Count + 1, URL = url, INFO = message };//匿名类型
            crawlerResultBindingSource.Add(pageInfo);
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            crawler.StartUrl = this.tb_url.Text;
            Match match = Regex.Match(crawler.StartUrl, SimpleCrawler.UrlParseRegex);
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            crawler.HostFilterRegex = "^" + host + "$";
            crawler.FileFilterRegex = @"((.html?|.aspx|.jsp|.php)$|^[^.]+$)";
            if (thread != null)
            {
                thread.Abort();
            }
            thread = new Thread(crawler.Crawl);
            thread.Start();
            lbl_message.Text = "爬虫启动";
        }
    }
}
