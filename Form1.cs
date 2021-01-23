using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StringDesigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\ASosyaL\Desktop\Keywords.txt";
            string[] _tempKeywords = System.IO.File.ReadAllLines(filePath);

            List<string> tempKeywords = new List<string>();
            foreach (var _tempKeyword in _tempKeywords)
            {
                if (!string.IsNullOrEmpty(_tempKeyword))
                {
                    tempKeywords.Add(_tempKeyword);
                }
            }

            Dictionary<int, string> dictionaryKeywords = new Dictionary<int, string>();
            int i = 0;
            foreach (var tempKeyword in tempKeywords)
            {
                foreach (var keyword in tempKeyword.Split(':'))
                {
                    dictionaryKeywords.Add(i, keyword);
                    i++;
                }
            }

            ListViewItem listViewItem = new ListViewItem();
            string temp;
            int j = 0;
            for (i = 0; i < dictionaryKeywords.Count; i++)
            {
                if (i % 2 == 0)
                {
                    temp = dictionaryKeywords[i];
                    listView1.Items.Add(temp);
                }
                else
                {
                    temp = dictionaryKeywords[i];
                    listView1.Items[j].SubItems.Add(temp);
                    j++;
                }
            }












        }



        /* boşlukları sil
        * satırı 2'ye böl ve dictionary'e at 
        *1'in katlarını ingilizce olarak 2'nin katını türkçe olarak ekrana yazdır
        */
















        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("İngilizcesi", 400);
            listView1.Columns.Add("Türkçesi", 100);
        }
    }
}
