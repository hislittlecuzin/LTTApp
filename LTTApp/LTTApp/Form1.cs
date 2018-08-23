using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LTTApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://linustechtips.com/main/");
        }

        //On Click of this button, the web page will load LTT home page. 
        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://linustechtips.com/main/");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://linustechtips.com/main/");
        }
    }
}
