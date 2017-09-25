using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador02
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            String link = "www.artic9980.wixsite.com/artic7789";
            webBrowser1.Navigate(link);
           
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pesquisa();
            textBox1.Text = "";
        }
        public void pesquisa()
        {
            webBrowser1.Navigate(textBox1.Text);
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}
