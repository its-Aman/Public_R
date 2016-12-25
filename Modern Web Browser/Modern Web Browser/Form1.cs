using MetroFramework;
using MetroFramework.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Web_Browser
    {
    public partial class Form1 : MetroFramework.Forms.MetroForm
        {
        public Form1()
            {
            InitializeComponent();
            }

        private void NewTab()
            {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            metroTabControl.Controls.Add(tab);
            metroTabControl.SelectTab(metroTabControl.TabCount - 1);
            WebBrowser browser = new WebBrowser() { ScriptErrorsSuppressed = true };
            browser.Parent = tab;
            browser.Dock = DockStyle.Fill;
            browser.Navigate(@"https://www.google.com");
            txtUrl.Text = @"https://www.google.com";
            browser.DocumentCompleted += Browser_DocumentCompleted;
            }

        private void ToolTipController()
            {
            MetroToolTip t = new MetroToolTip();
            t.UseFading = true;
            t.UseAnimation = true;
            t.Theme = MetroFramework.MetroThemeStyle.Light;
            t.SetToolTip(this.lnkBack, "Back");
            t.SetToolTip(this.lnkForward, "Forward");
            t.SetToolTip(this.lnkGo, "Go");
            t.SetToolTip(this.lnkNewTab, "New Tab");
            }

        private void Form1_Load(object sender, EventArgs e)
            {
            NewTab();
            ToolTipController();
            }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
            {
            WebBrowser browser = metroTabControl.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
                {
                metroTabControl.SelectedTab.Text = browser.DocumentTitle;
                }
            }

        private void lnkBack_Click(object sender, EventArgs e)
            {
            WebBrowser browser = metroTabControl.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
                {
                if (browser.CanGoBack)
                    {
                    browser.GoBack();
                    }
                }
            }

        private void lnkForward_Click(object sender, EventArgs e)
            {
            WebBrowser browser = metroTabControl.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
                {
                if (browser.CanGoForward)
                    {
                    browser.GoForward();
                    }
                }
            }

        private void btnGo_Click(object sender, EventArgs e)
            {
            WebBrowser browser = metroTabControl.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
                {
                browser.Navigate(txtUrl.Text);
                }

            }

        private void linkNewTab_Click(object sender, EventArgs e)
            {
            if(MetroMessageBox.Show(this, "Do you want to open a new tab", "Conform Action", MessageBoxButtons.OKCancel,MessageBoxIcon.None) == DialogResult.OK)
                {
                NewTab();
                }
            }
        }
    }
