using Gecko;
using System;
using System.Windows.Forms;

namespace Gecko2TestWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Xpcom.Initialize("Firefox");
            geckoWebBrowser1.Navigate("https://stmikpontianak.net/011100862/webview_lanjutan.html");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            geckoWebBrowser1.AddMessageEventListener(
                "ShowFontDialog",
                (string nothing) => ShowFontDialog()
                );

            geckoWebBrowser1.AddMessageEventListener(
                "ShowMessageBox",
                (string message) => ShowMessageBox(message)
                );
        }

        private void ShowFontDialog()
        {
            fontDialog1.ShowDialog();
        }

        private void ShowMessageBox(string message)
        {
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
