using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace homework9
{
    class Crawler {
        public event Action<Crawler> CrawlerStopped;
        public event Action<Crawler, string, string> PageDownloaded;

        public int MaxPage { get; set; } //最大下载数量
        Queue<string> pending = new Queue<string>(); //待下载队列
        public Dictionary<string, bool> DownloadedPages { get; } = new Dictionary<string, bool>(); //已下载网页

        //URL检测表达式，用于在HTML文本中查找URL
        public static readonly string UrlDetectRegex = @"(href|HREF)[]*=[]*[""'](?<url>[^""'#>]+)[""']";
        //URL解析表达式
        public static readonly string UrlParseRegex = @"^(?<site>(?<protocol>https?)://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)"; 

        public string HostFilter { get; set; } //主机过滤规则
        public string FileFilter { get; set; } //文件过滤规则
        public string StartUrl { get; set; } //起始网址
        public Encoding HtmlEncoding { get; set; } //网页编码

        public Crawler() {
            MaxPage = 100;
            HtmlEncoding = Encoding.UTF8;
        }

        public void Crawl() { //爬虫
            //清空队列
            DownloadedPages.Clear();
            pending.Clear();
            pending.Enqueue(StartUrl); //起始网址进入待下载队列
            while(DownloadedPages.Count < MaxPage && pending.Count > 0) {
                string url = pending.Dequeue();
                try {
                    string html = Download(url); //下载
                    DownloadedPages[url] = true; //url页下载完成
                    PageDownloaded(this, url, "success");
                    Parse(html, url); //解析并加入新链接
                }catch (Exception ex) {
                    PageDownloaded(this, url, " Error:" + ex.Message);
                }
            }
            CrawlerStopped(this);
        }
        public string Download(string url) { //下载
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string html = webClient.DownloadString(url);
            string fileName = DownloadedPages.Count.ToString();
            File.WriteAllText(fileName, html, Encoding.UTF8);
            return html;
        }
        public void Parse(string html, string pageUrl) { //解析器
            var matches = new Regex(UrlDetectRegex).Matches(html);
            foreach (Match match in matches) {
                string linkurl = match.Groups["url"].Value;
                if (linkurl == null || linkurl == "" || linkurl.StartsWith("javascript:")) continue;
                linkurl = FixUrl(linkurl, pageUrl);
                Match linkUrlMatch = Regex.Match(linkurl, UrlParseRegex);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter) && !DownloadedPages.ContainsKey(linkurl))
                    pending.Enqueue(linkurl);
            }
        }
        private string FixUrl(string url,string pageUrl) { //将相对地址转成完整地址
            if (url.Contains("://")) {
                return url;
            }
            if (url.StartsWith("//")) {
                Match urlMatch = Regex.Match(pageUrl, UrlParseRegex);
                String protocol = urlMatch.Groups["protocol"].Value;
                return protocol + ":" + url;
            }
            if (url.StartsWith("/")) {
                Match urlMatch = Regex.Match(pageUrl, UrlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }
            if (url.StartsWith("../")) {
                url = url.Substring(3);
                int idx = pageUrl.LastIndexOf('/');
                return FixUrl(url, pageUrl.Substring(0, idx));
            }
            if (url.StartsWith("./")) {
                return FixUrl(url.Substring(2), pageUrl);
            }
            //非上述开头的相对路径
            int end = pageUrl.LastIndexOf("/");
            return pageUrl.Substring(0, end) + "/" + url;
        }
    }
}
