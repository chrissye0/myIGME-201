using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE20Dom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            this.webBrowser1.DocumentCompleted += new
WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);

            // or if you want to use the URL  (only use one of these Navigate() statements)
            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");

        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            this.webBrowser1.ScriptErrorsSuppressed = true;

            // Select h1s
            htmlElementCollection = webBrowser1.Document.GetElementsByTagName("h1");
            // First h1
            htmlElementCollection[0].InnerHtml = "My UFO Page";

            // Select h2s
            htmlElementCollection = webBrowser1.Document.GetElementsByTagName("h2");
            // First h2
            htmlElementCollection[0].InnerHtml = "My UFO Info";
            // Second h2
            htmlElementCollection[1].InnerHtml = "My UFO Pictures";
            // Third h2
            htmlElementCollection[2].InnerHtml = "";
            
            // Select body element
            htmlElement = webBrowser1.Document.Body;
            // sans-serif text and reddish text
            htmlElement.Style = "font-family: sans-serif; color: #a33405";

            htmlElementCollection = webBrowser1.Document.GetElementsByTagName("p");
            htmlElement = htmlElementCollection[0];
            htmlElementCollection[0].InnerHtml = "Report your UFO sightings here: " + "<a href=\"https://nuforc.org/\">WWW.NUFORC.ORG</a>";
            webBrowser1.Document.Body.AppendChild(htmlElement);
            htmlElementCollection[0].InnerText = "";


            htmlElement.Style = "color: green; font-weight: bold; font-size: 2em; text-transform: uppercase; text-shadow: 3px 2px #A44";

            htmlElement = htmlElementCollection[1];
            htmlElement.InnerText = "";

            htmlElement = webBrowser.Document.CreateElement("img");
            htmlElement.SetAttribute("src", "https://media.vanityfair.com/photos/6480b24fbafc6505d77122c4/1:1/w_1443,h_1443,c_limit/vf623-ufo.jpg");
            htmlElement.Style = "width: 50%";
            webBrowser1.Document.Body.AppendChild(htmlElement);

            htmlElement = webBrowser1.Document.CreateElement("footer");
            htmlElement.InnerHtml = "&copy; 2023 Christine E";
            webBrowser1.Document.Body.AppendChild(htmlElement);

        }

    }
}
