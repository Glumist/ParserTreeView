using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public MainForm()
        {
            InitializeComponent();

            _allNodes = new List<TreeNode>();
        }

        private void btParse_Click(object sender, EventArgs e)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            if (sender == btParse)
            {
                if (string.IsNullOrWhiteSpace(tbAddress.Text))
                    return;
                string htmlString = GetHtmlString(tbAddress.Text);
                doc.LoadHtml(htmlString);
                //webBrowser1.Url = new Uri(tbAddress.Text);
                webBrowser1.DocumentText = htmlString;
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

        public string GetHtmlString(string url)
        {
            WebClient client = new WebClient();
            client.Proxy = null;
            client.Encoding = System.Text.Encoding.GetEncoding("utf-8");
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:18.0) Gecko/20100101 Firefox/18.0");
            return client.DownloadString(url);
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
    }
}
