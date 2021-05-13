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
        Crawler crawler = new Crawler();
        BindingSource resultBindingSourse = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            dataGridView_result.DataSource = resultBindingSourse;
            crawler.CrawlerStopped += crawler_CrawlerStopped;
            crawler.PageDownloaded += crawler_PageDownloaded;
        }
        private void crawler_CrawlerStopped(Crawler obj)
        {
            Action action = () => lbl_info.Text = "停止爬取"; //Action封装方法
            if (this.InvokeRequired) {//线程安全问题
                this.Invoke(action);
            }else {
                action();
            }
        }
        private void crawler_PageDownloaded(Crawler crawler, string url, string info)
        {
            var pageInfo = new { Index = resultBindingSourse.Count + 1, URL = url, INFO = info };//匿名类型
            Action action = () => { resultBindingSourse.Add(pageInfo); };
            if (this.InvokeRequired) {//线程安全问题
                this.Invoke(action);
            }else {
                action();
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            resultBindingSourse.Clear();
            crawler.StartUrl = textBoxUrl.Text;
            Match match = Regex.Match(crawler.StartUrl, Crawler.UrlParseRegex);
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            crawler.HostFilter = "^" + host + "$";
            crawler.FileFilter = "((.html?|.aspx|.jsp|.php)$|^[^.]+$)";
            new Thread(crawler.Crawl).Start();
            lbl_info.Text = "爬虫启动";
        }
    }
}
