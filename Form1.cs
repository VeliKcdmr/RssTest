using System;
using System.Xml;
using System.Windows.Forms;

namespace RssTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void xmloku(string link)
        {
            XmlTextReader xmloku = new XmlTextReader(link);
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            xmloku("https://www.hurriyet.com.tr/rss/anasayfa");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            xmloku("https://www.sozcu.com.tr/feeds-haberler");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            xmloku("http://www.cumhuriyet.com.tr/rss/son_dakika.xml");
        }
    }
}
