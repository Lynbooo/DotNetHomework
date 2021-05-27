using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace homework9
{
    class SimpleCrawler
    {
        //爬虫结束事件
        public event Action<SimpleCrawler> CrawlerEnding;
        //当前页面完成下载事件
        public event Action<SimpleCrawler, string, string> ThisPageDownloaded;

        //爬取的起始URL
        public string StartUrl { get; set; }
        //URL列表
        private Hashtable urls = new Hashtable();
        //最大爬取页数
        private int MaxPage { get; set; }
        //已爬取的页面个数
        private int count = 0;
        //待下载队列
        Queue<string> downloadQueue = new Queue<string>();

        //URL检测表达式，在HTML文本中查找URL加入下载队列
        public static readonly string UrlDetectRegex = @"(href|HREF)[]*=[]*[""'](?<url>[^""'#>]+)[""']";
        //URL解析表达式，解析网站内容
        public static readonly string UrlParseRegex = @"^(?<site>(?<protocol>https?)://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
        //host过滤表达式，保证只爬取特定网站页面
        public string HostFilterRegex { get; set; } = @"";
        //file过滤表达式，保证只爬取htm/html/aspx/jsp/php网页
        public string FileFilterRegex { get; set; } = @"((.html?|.aspx|.jsp|.php)$|^[^.]+$)";

        public SimpleCrawler()
        {
            MaxPage = 10;
        }

        public void Crawl() //爬虫
        {
            urls = new Hashtable();
            this.urls.Add(StartUrl, false); //起始爬取网址加入待下载队列
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }
                if (current == null || count > MaxPage) break;
                try
                {
                    Console.WriteLine("爬行" + current + "页面!");
                    string html = Download(current); // 下载
                    urls[current] = true;
                    Parse(html, current);//解析,并加入新的链接
                    ThisPageDownloaded(this, current, "SUCCESS: 爬取成功"); //触发当前页面下载完成事件
                    count++;
                }
                catch(Exception e0)
                {
                    ThisPageDownloaded(this, current, "ERROR: "+ e0.Message); //触发当前页面下载失败事件
                }        
            }
            CrawlerEnding(this); //触发爬虫爬取结束事件
        }
        public string Download(string url) //下载
        {
            try
            {
               WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string html = webClient.DownloadString(url);
            string fileName = count.ToString();
            File.WriteAllText(fileName, html, Encoding.UTF8);
            return html;
            }
            catch(Exception e1)
            {
                Console.WriteLine(e1.Message);
                return "";
            }
        }

        public void Parse(string html, string pageUrl) //解析
        {
            MatchCollection matches = new Regex(UrlDetectRegex).Matches(html);
            foreach (Match match in matches)
            {
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "" || linkUrl.StartsWith("javascript:")) continue;
                linkUrl = ConvertUrl(linkUrl, pageUrl); //转换为绝对路径，pageUrl为当前爬取页面的url
                //解析出host和file两部分
                Match linkUrlMatch = Regex.Match(linkUrl, UrlParseRegex);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                //过滤重复、非html/aspx/jsp页面
                if (Regex.IsMatch(host, HostFilterRegex) && Regex.IsMatch(file, FileFilterRegex) && (urls[linkUrl] == null))
                {
                    urls[linkUrl] = false; //将转换后的url加入队列，设置为false表示未爬取
                }
            }
        }

        private string ConvertUrl(string url, string pageUrl) //将相对路径地址转换为绝对路径地址
        {
            if (url.Contains("://"))
            {
                return url;
            }
            if (url.StartsWith("//"))
            {
                Match urlMatch = Regex.Match(pageUrl, UrlParseRegex);
                String protocol = urlMatch.Groups["protocol"].Value;
                return protocol + ":" + url;
            }
            if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(pageUrl, UrlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }
            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = pageUrl.LastIndexOf('/');
                return ConvertUrl(url, pageUrl.Substring(0, idx));
            }
            if (url.StartsWith("./"))
            {
                return ConvertUrl(url.Substring(2), pageUrl);
            }
            //非上述开头的相对路径
            int end = pageUrl.LastIndexOf("/");
            return pageUrl.Substring(0, end) + "/" + url;
        }

    }

}
