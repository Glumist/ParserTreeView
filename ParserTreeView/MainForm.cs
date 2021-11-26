using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ParserTreeView
{
    public partial class MainForm : Form
    {
        List<TreeNode> _allNodes;
        CookieContainer _cookieContainer;

        public MainForm()
        {
            InitializeComponent();

            _allNodes = new List<TreeNode>();
            GetCookies();
        }

        private void btParse_Click(object sender, EventArgs e)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            if (sender == btParse)
            {
                if (string.IsNullOrWhiteSpace(tbAddress.Text))
                    return;
                try
                {
                    string htmlString = GetHtmlString(tbAddress.Text);
                    doc.LoadHtml(htmlString);
                }
                catch { return; }
                //webBrowser1.Url = new Uri(tbAddress.Text);
                //webBrowser1.DocumentText = htmlString;
            }
            else if (sender == tsbParseText)
                doc.LoadHtml(tbFullText.Text);
            else
                return;

            tbFullText.Text = doc.DocumentNode.OuterHtml;
            tvStructure.Nodes.Clear();
            _allNodes.Clear();
            TreeNode rootNode = GetNode(doc.DocumentNode, _allNodes);
            tvStructure.Nodes.Add(rootNode);
            _allNodes.Add(rootNode);
        }

        private void tbAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btParse_Click(sender, e);
        }

        /*public string GetHtmlString(string url)
        {
            WebClient client = new WebClient();
            client.Container = new CookieContainer();
            client.Proxy = null;
            client.Encoding = System.Text.Encoding.GetEncoding("utf-8");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:18.0) Gecko/20100101 Firefox/18.0");
            return client.DownloadString(url);
        }*/

        /*public string GetHtmlString(string url)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept-Language", "ru-Ru,ru;q=0.5");
                client.DefaultRequestHeaders.Add("Accept-Charset", "Windows-1252,utf-8;q=0.7,*;q=0.7");
                client.DefaultRequestHeaders.Add("UserAgent", "Opera/9.80 (Windows NT 6.1; WOW64; MRA 8.2 (build 6870)) Presto/2.12.388 Version/12.16");
                return (client.GetStringAsync(url)).Result;
            }
        }*/

        public string GetHtmlString(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.AllowAutoRedirect = true;
            req.ContentType = "application/x-www-form-urlencoded";
            req.Referer = "http://google.com";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:50.0) Gecko/20100101 Firefox/50.0";

            req.CookieContainer = _cookieContainer;

            var resp = (HttpWebResponse)req.GetResponse();

            StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding("utf-8"));
            return sr.ReadToEnd();
        }

        private void GetCookies()
        {
            _cookieContainer = new CookieContainer();
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("_ym_d", "1609170128"));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("_ym_isad", "1"));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("_ym_uid", "1609162596484861180"));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("_ym_visorc_10630330", "b"));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("_ym_visorc_22663942", "b"));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("_ym_visorc_238724", "w"));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("_ym_visorc_238735", "w"));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("_ym_visorc_26812653", "b"));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("_ym_visorc_56177992", "b"));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("cmtchd", "MTYwOTE2OTE1OTMwOQ"));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("crookie", "D8yRMv4OHAQd3fhZjuKRhaLPuSCyDzYh/GehxpmL+fABjB398fHmvlvoZ8ooz6QXhmsqurAv+/XXrfWIRTEWiZKL08I="));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("gdpr", "0"));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("yandexuid", "6276612201542871157"));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("yandex_gid", "35"));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("i", "J8dgPYD8cVXqny6MRj7Cw5tmzRmabXnjg4k7OH0qUt5aVcz/IBpKIxlcrts4J7rpZgEPeK61p2QCJEo0AhHU9ipr7sM="));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("kpunk", "1"));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("mda", "0"));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("mda2_beacon", "1609169716037"));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("spravka", "dD0xNjA5MTY5MjAwO2k9MTg1LjUyLjEzNC4xMTI7dT0xNjA5MTY5MjAwMDUxNjU5NTk1O2g9MDVmYmZlNzg3NmNkYjEzOTkzMjRiOGFjM2RhMGY4N2Q="));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("sso_status", "sso.passport.yandex.ru:synchronized"));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("tc", "431"));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("user_country", "ru"));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("ya_sess_id", "noauth:1609169716"));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("yuidss", "6276612201542871157"));
            _cookieContainer.Add(new Uri("https://www.kinopoisk.ru"), new Cookie("ys", "c_chck.2458526112"));
        }

        public static TreeNode GetNode(HtmlNode node, List<TreeNode> nodesList)
        {
            TreeNode treeNode = new TreeNode(node.Name + GetNodeAttributes(node));

            if (node.HasChildNodes)
            {
                foreach (HtmlNode child in node.ChildNodes)
                {
                    TreeNode childNode = GetNode(child, nodesList);
                    if (childNode != null)
                    {
                        treeNode.Nodes.Add(childNode);
                        nodesList.Add(childNode);
                    }
                }
            }
            else if (node.Name != "#text" || !string.IsNullOrWhiteSpace(node.InnerText))
                treeNode.Text += ":" + node.InnerText;
            else
                return null;

            return treeNode;
        }

        private static string GetNodeAttributes(HtmlNode node)
        {
            string result = "(";
            foreach (HtmlAttribute att in node.Attributes)
                result += att.Name + "=" + att.Value + ";";
            if (result.Length > 1)
                result = result.Remove(result.Length - 1);
            result += ")";
            return result;
        }

        #region Search

        private TreeNode[] _currentNodeMatches;
        private int _nextNodeIndex = 0;

        private void tstbSearchText_TextChanged(object sender, EventArgs e)
        {
            _currentNodeMatches = null;
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tstbSearchText.Text))
                return;

            if (_currentNodeMatches == null)
            {
                //It's a new Search
                _nextNodeIndex = 0;
                _currentNodeMatches = FindNodes(tstbSearchText.Text);
            }

            if (_nextNodeIndex >= 0 && _currentNodeMatches.Length > 0 && _nextNodeIndex < _currentNodeMatches.Length)
            {
                TreeNode selectedNode = _currentNodeMatches[_nextNodeIndex];
                _nextNodeIndex++;
                tvStructure.SelectedNode = selectedNode;
                tvStructure.SelectedNode.Expand();
                tvStructure.Select();
            }
        }

        private TreeNode[] FindNodes(string searchText)
        {
            List<TreeNode> foundNodes = new List<TreeNode>();
            foreach (TreeNode node in _allNodes)
                if (node.Text.ToLower().Contains(searchText.ToLower()))
                    foundNodes.Add(node);

            return foundNodes.ToArray();
        }

        #endregion

        private void btTest_Click(object sender, EventArgs e)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(tbFullText.Text);
            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes(tbTestText.Text);
            if (nodes.Count == 0)
                MessageBox.Show("not found");
            foreach (HtmlNode node in nodes)
                MessageBox.Show(node.InnerHtml);
            /*HtmlNode testNode = doc.DocumentNode.SelectSingleNode(tbTestText.Text);
            if (testNode != null)
            {
                MessageBox.Show(testNode.OuterHtml);
                MessageBox.Show(testNode.InnerHtml);
                if (testNode.NextSibling != null)
                {
                    if (testNode.NextSibling.FirstChild != null && testNode.NextSibling.FirstChild.LastChild != null)
                        MessageBox.Show(testNode.NextSibling.FirstChild.LastChild.InnerText);
                    if (testNode.NextSibling.LastChild != null && testNode.NextSibling.LastChild.LastChild != null)
                        MessageBox.Show(testNode.NextSibling.LastChild.LastChild.InnerText);
                }
            }
            else
                MessageBox.Show("not found");*/
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = tbFullText.Text;
        }
    }
}