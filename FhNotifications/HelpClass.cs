using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FhNotifications
{
    public static class HelpClass
    {
        public static void SetLinksInLinkLabelFromHtmlTags(LinkLabel linkLabel)
        {
            var linkTagMatches = Regex.Matches(linkLabel.Text, "<a(.*)>(.*)</a>", RegexOptions.Singleline);

            foreach (Match linkTagMatch in linkTagMatches)
            {
                var document = new HtmlAgilityPack.HtmlDocument();
                document.LoadHtml(linkTagMatch.Value);

                var linkTag     = document.DocumentNode.ChildNodes.FindFirst("a");
                var link        = linkTag.Attributes["href"].Value;
                var linkText    = linkTag.InnerText;

                var regex       = new Regex(Regex.Escape(linkTagMatch.Value));
                linkLabel.Text  = regex.Replace(linkLabel.Text, linkText, 1);
                linkLabel.Links.Add(new LinkLabel.Link(linkTagMatch.Index, linkText.Length, link));
            }
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
