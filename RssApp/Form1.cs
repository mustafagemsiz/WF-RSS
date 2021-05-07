using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RssApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextReader xmloku = new XmlTextReader("https://www.sabah.com.tr/rss/anasayfa.xml");
            while (xmloku.Read())
            {
                
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());  
                }
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlTextReader xmloku = new XmlTextReader("https://www.cumhuriyet.com.tr/rss/son_dakika.xml");
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
            XmlTextReader xmloku = new XmlTextReader("https://www.fotomac.com.tr/rss/anasayfa.xml");
            while (xmloku.Read())
            {

                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XmlTextReader xmloku = new XmlTextReader("https://rss.nytimes.com/services/xml/rss/nyt/HomePage.xml");
            while (xmloku.Read())
            {

                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
        
        }
    }
}
